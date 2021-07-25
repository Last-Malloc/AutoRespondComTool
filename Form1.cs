using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SendCodeServer
{
    public partial class Form1 : Form
    {
        // 键-值数据
        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

        #region 键-值数据和配置的保持和加载（txt)

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        // 加载文件(txt，以###为分隔符）
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            try
            {
                using (StreamReader sr = new StreamReader("key_value.txt"))
                {
                    //以###为分隔符
                    //依次写入 提示键非法字符 提示值非法字符 服务器端口 客户端连接ip 客户端连接端口
                    string line;
                    line = sr.ReadLine();
                    if (line == null)
                        throw new Exception();
                    string[] tSplit = line.Split("###");
                    if (tSplit[0] == "1")
                        checkIllegalTipForKey.Checked = true;
                    else
                        checkIllegalTipForKey.Checked = false;
                    if (tSplit[1] == "1")
                        checkIllegalTipForValue.Checked = true;
                    else
                        checkIllegalTipForValue.Checked = false;
                    textPort.Text = tSplit[2];
                    textClientIP.Text = tSplit[3];
                    textClientPort.Text = tSplit[4];
                    if (tSplit[5] == "1")
                        radioHex.Checked = true;
                    else
                        radioChar.Checked = true;
                    if (tSplit[6] == "1")
                        checkAutoSend.Checked = true;
                    else
                    {
                        checkAutoSend.Checked = false;
                        textDelay.Enabled = false;
                    }
                    textDelay.Text = tSplit[7];
                    if (tSplit[8] == "1")
                        checkIllegalTipForSend.Checked = true;
                    else
                        checkIllegalTipForSend.Checked = false;

                    //键-值数据
                    while ((line = sr.ReadLine()) != null)
                    {
                        tSplit = line.Split("###");
                        List<string> tList = new List<string>();
                        for (int i = 1; i < tSplit.Length; ++i)
                            tList.Add(tSplit[i]);
                        data.Add(tSplit[0], tList);
                        listKey.Items.Add(tSplit[0]);
                    }
                }
            }
            catch 
            {
                checkIllegalTipForKey.Checked = false;
                checkIllegalTipForValue.Checked = false;
                textPort.Text = "4444";
                textClientIP.Text = "127.0.0.1";
                textClientPort.Text = "8888";
                radioHex.Checked = true;
                checkAutoSend.Checked = false;
                textDelay.Enabled = false;
                textDelay.Text = "500";
                checkIllegalTipForSend.Checked = false;
            }
        }

        // 保存文件(txt，以###为分隔符)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("key_value.txt"))
                {
                    string firstLine = "";
                    //以###为分隔符
                    //依次写入 提示键非法字符 提示值非法字符 服务器端口 客户端连接ip 客户端连接端口
                    if (checkIllegalTipForKey.Checked)
                        firstLine += "1";
                    else
                        firstLine += "0";
                    if (checkIllegalTipForValue.Checked)
                        firstLine += "###1";
                    else
                        firstLine += "###0";
                    if (textPort.Text.Length == 0)
                        firstLine += "###4444";
                    else
                        firstLine += "###" + textPort.Text;
                    if (textClientIP.Text.Length == 0)
                        firstLine += "###127.0.0.1";
                    else
                        firstLine += "###" + textClientIP.Text;
                    if (textClientPort.Text.Length == 0)
                        firstLine += "###8888";
                    else
                        firstLine += "###" + textClientPort.Text;
                    if (radioHex.Checked)
                        firstLine += "###1";
                    else
                        firstLine += "###0";
                    if (checkAutoSend.Checked)
                        firstLine += "###1";
                    else
                        firstLine += "###0";
                    if (textDelay.Text.Length == 0)
                        firstLine += "###500";
                    else
                        firstLine += "###" + textDelay.Text;
                    if (checkIllegalTipForSend.Checked)
                        firstLine += "###1";
                    else
                        firstLine += "###0";
                    sw.WriteLine(firstLine);
                    foreach (string i in data.Keys)
                    {
                        List<string> tList = data[i];
                        string tStr = i;
                        foreach (string j in tList)
                        {
                            tStr += "###" + j;
                        }
                        sw.WriteLine(tStr);
                    }
                }
            }
            catch { }
        }

        #endregion

        #region 键-值数据操作

        //十六进制数的合法字符
        List<char> hexlegal = new () { '0', '1', '2', '3', '4',
            '5', '6', '7', '8', '9',
            'a', 'A', 'b', 'B', 'c', 'C', 
            'd', 'D', 'e', 'E', 'f', 'F', ' '};

        //添加键
        private void textKey_TextChanged(object sender, EventArgs e)
        {
            int pos = textKey.SelectionStart;
            if (pos > 0)
            {
                char charFin = textKey.Text[pos - 1];
                if (!hexlegal.Contains(charFin))
                {
                    if (checkIllegalTipForKey.Checked)
                        MessageBox.Show("添加键输入框输入非法字符：" + charFin.ToString());
                    //此行为出发下一次的TextChanged且SelectionStart为1，故应加判断SelectionStart>0
                    textKey.Text = textKey.Text.Replace(charFin.ToString(), "");
                    textKey.SelectionStart = pos - 1;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string key = textKey.Text.Replace(" ", "").ToUpper();
            if (key.Length == 0)
            {
                MessageBox.Show("键有效长度不许为0！");
                return;
            }
            if (key.Length % 2 != 0)
            {
                MessageBox.Show("键有效长度不许为奇数！");
                return;
            }
            string tmp = "";
            for (int i = 0; i < key.Length / 2; ++i)
            {
                if (i != 0)
                    tmp += " ";
                tmp += key.Substring(2 * i, 2);
            }
            key = tmp;
            if (data.ContainsKey(key))
            {
                MessageBox.Show("键不许重复！");
                return;
            }
            data.Add(key, new List<string>());
            listKey.Items.Add(key);
            listKey.SelectedIndex = listKey.Items.Count - 1;
            textKey.Text = "";
        }

        //添加值
        private void textValue_TextChanged(object sender, EventArgs e)
        {
            int pos = textValue.SelectionStart;
            if (pos > 0)
            {
                char charFin = textValue.Text[pos - 1];
                if (!hexlegal.Contains(charFin))
                {
                    if (checkIllegalTipForValue.Checked)
                        MessageBox.Show("添加值输入框输入非法字符：" + charFin.ToString());
                    //此行为出发下一次的TextChanged且SelectionStart为1，故应加判断SelectionStart>0
                    textValue.Text = textValue.Text.Replace(charFin.ToString(), "");
                    textValue.SelectionStart = pos - 1;
                }
            }
        }
        private void valueAdd_Click(object sender, EventArgs e)
        {
            if (listKey.SelectedIndex == -1)
            {
                MessageBox.Show("没有指定键！");
                return;
            }
            string value = textValue.Text.Replace(" ", "").ToUpper();
            if (value.Length == 0)
            {
                MessageBox.Show("值有效长度不许为0！");
                return;
            }
            if (value.Length % 2 != 0)
            {
                MessageBox.Show("值有效长度不许为奇数！");
                return;
            }
            string tmp = "";
            for (int i = 0; i < value.Length / 2; ++i)
            {
                if (i != 0)
                    tmp += " ";
                tmp += value.Substring(2 * i, 2);
            }
            value = tmp;
            data[listKey.Text].Add(value);
            listValue.Items.Add(value);
            listValue.SelectedIndex = listValue.Items.Count - 1;
            textValue.Text = "";
        }

        //选择的键改变
        private void listKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listKey.SelectedIndex;
            listValue.Items.Clear();
            if (index != -1)
            {
                List<string> tList = data[listKey.Text];
                foreach (string i in tList)
                {
                    listValue.Items.Add(i);
                }
            }
        }

        //删除键
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listKey.SelectedIndex;
            if (index != -1)
            {
                string key = listKey.Text;
                listKey.SelectedIndex = -1;
                data.Remove(key);
                listKey.Items.RemoveAt(index);
            }
        }

        //删除值
        private void valueDele_Click(object sender, EventArgs e)
        {
            int index = listValue.SelectedIndex;
            if (index != -1)
            {
                data[listKey.Text].RemoveAt(index);
                listValue.Items.RemoveAt(index);
                listValue.SelectedIndex = -1;
            }
        }

        //复制键
        private void keyCopy_Click(object sender, EventArgs e)
        {
            if (listKey.SelectedIndex != -1)
            {
                Clipboard.Clear();
                Clipboard.SetDataObject(listKey.Text);
            }
        }

        //复制值
        private void valueCopy_Click(object sender, EventArgs e)
        {
            if (listValue.SelectedIndex != -1)
            {
                Clipboard.Clear();
                Clipboard.SetDataObject(listValue.Text);
            }
        }

        #endregion

        #region 作为服务器Server

        //打印信息计数
        int printCnt = 0;
        //打印到信息交互窗口： [序号][时间]内容
        private void printToWin(string info)
        {
            listRecent.Items.Add("[" + (++printCnt).ToString() + "][" + DateTime.Now.TimeOfDay.ToString().Substring(0, 12) + "]" + info);
        }

        Socket socketServer = null;
        Dictionary<string, Socket> sendSocketDic = null;

        //开启服务器
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPort.Text.Length == 0)
                {
                    MessageBox.Show("端口号不许为空！");
                    return;
                }
                printToWin("服务器开启中...");
                sendSocketDic = new Dictionary<string, Socket>();
                socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                IPEndPoint pointServer = new IPEndPoint(ip, Convert.ToInt32(textPort.Text));
                socketServer.Bind(pointServer);
                socketServer.Listen(50);
                Thread threadServer = new Thread(listen);
                threadServer.IsBackground = true;
                threadServer.Start();

                btnConn.Enabled = false;
                btnDisconn.Enabled = false;
                printToWin("服务器开启成功！");
            }
            catch 
            {
                printToWin("服务器开启失败！");
            }
        }

        //关闭服务器
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                printToWin("服务器关闭中...");

                foreach (Socket i in sendSocketDic.Values)
                {
                    try
                    {
                        i.Close();
                    }
                    catch { }
                }
                sendSocketDic.Clear();
                comboSendSocket.Items.Clear();

                try
                {
                    socketServer.Close();
                }
                catch { }

                btnConn.Enabled = true;
                btnDisconn.Enabled = true;
                printToWin("服务器关闭成功！");
            }
            catch
            {
                printToWin("服务器关闭失败！");
            }
        }

        //监听
        private void listen()
        {
            try
            {
                while (true)
                {
                    Socket socketSend = socketServer.Accept();
                    sendSocketDic.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    comboSendSocket.Items.Add(socketSend.RemoteEndPoint.ToString());
                    comboSendSocket.SelectedIndex = comboSendSocket.Items.Count - 1;
                    printToWin(socketSend.RemoteEndPoint.ToString() + "连接到本服务器");
               
                    Thread thread = new Thread(onReceiveData);
                    thread.IsBackground = true;
                    thread.Start(socketSend);
                }
            }
            catch (Exception)
            {
            }
        }

        //接收到数据
        private void onReceiveData(object o)
        {
            Socket socketSend = (Socket)o;
            string info = socketSend.RemoteEndPoint.ToString();
            try
            {
                byte[] buffer = new byte[3 * 1024 * 1024];
                while (true)
                {
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                        throw new Exception();

                    string recStr = "";
                    for (int i = 0; i < r; ++i)
                    {
                        if (i != 0)
                            recStr += " ";
                        recStr += buffer[i].ToString("X2");
                    }
                    if (radioHex.Checked)
                    {
                        printToWin("[" + info + "]收到：[" + recStr + "]");
                    }
                    else
                    {
                        printToWin("[" + info + "]收到：[" + System.Text.Encoding.ASCII.GetString(buffer.Take(r).ToArray()) + "]");
                    }
                    
                    if (checkAutoSend.Checked)
                    {
                        if (data.ContainsKey(recStr))
                        {
                            List<string> listTmp = data[recStr];
                            foreach (string i in listTmp)
                            {
                                int delay = 0;
                                try
                                {
                                    delay = Int32.Parse(textDelay.Text);
                                }
                                catch
                                { }
                                Thread.Sleep(delay);
                                socketSend.Send(strToToHexBytes(i.Replace(" ", "")));
                                printToWin("[" + info + "]回复：[" + i + "]");
                            }
                        }
                        else
                        {
                            printToWin("[" + info + "]回复：没有对应的处理！");
                        }
                    }
                }
            }
            catch (Exception)
            {
                if (btnConn.Enabled == false)
                {
                    try
                    {
                        sendSocketDic[info].Close();
                    }
                    catch { }
                    try
                    {
                        printToWin(info + "从本服务器断开");
                        sendSocketDic.Remove(info);
                        comboSendSocket.Items.Remove(info);
                        if (comboSendSocket.Items.Count > 0)
                            comboSendSocket.SelectedIndex = 0;
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        clientSocket.Close();
                    }
                    catch { }
                    try
                    {
                        btnStart.Enabled = true;
                        btnStop.Enabled = true;
                        if (activeDisconn == false)
                            printToWin("(被动)断开服务器" + textClientIP.Text + ":" + textClientPort.Text + "成功！");
                    }
                    catch { }
                }
            }
        }

        //16进制字符串转byte，例如"55AA"转0x55 0xAA
        private static byte[] strToToHexBytes(string hexstring)
        {
            try
            {
                hexstring = hexstring.Replace(" ", "");
                if ((hexstring.Length % 2) != 0)
                    hexstring += " ";
                byte[] returnBytes = new byte[hexstring.Length / 2];
                for (int i = 0; i < returnBytes.Length; i++)
                    returnBytes[i] = Convert.ToByte(hexstring.Substring(i * 2, 2), 16);
                return returnBytes;
            }
            catch { }
            byte[] tmp = Array.Empty<byte>();
            return tmp;
        }

        //清空信息交互窗口
        private void btnClear_Click(object sender, EventArgs e)
        {
            listRecent.Items.Clear();
        }

        //自动回复开关的切换事件
        private void checkAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAutoSend.Checked)
                textDelay.Enabled = true;
            else
                textDelay.Enabled = false;
        }

        private void textSend_TextChanged(object sender, EventArgs e)
        {
            int pos = textSend.SelectionStart;
            if (pos > 0)
            {
                char charFin = textSend.Text[pos - 1];
                if (!hexlegal.Contains(charFin))
                {
                    if (checkIllegalTipForSend.Checked)
                        MessageBox.Show("发送输入框输入非法字符：" + charFin.ToString());
                    //此行为出发下一次的TextChanged且SelectionStart为1，故应加判断SelectionStart>0
                    textSend.Text = textSend.Text.Replace(charFin.ToString(), "");
                    textSend.SelectionStart = pos - 1;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string send = textSend.Text.Replace(" ", "").ToUpper();
            if (send.Length == 0)
            {
                MessageBox.Show("发送数据有效长度不许为0！");
                return;
            }
            if (send.Length % 2 != 0)
            {
                MessageBox.Show("发送数据有效长度不许为奇数！");
                return;
            }
            if (comboSendSocket.SelectedIndex != -1)
            {
                sendSocketDic[comboSendSocket.Text].Send(strToToHexBytes(textSend.Text.Replace(" ", "")));
                textSend.Text = "";
            }
            else
            {
                MessageBox.Show("请选择要发送到的客户端");
            }
        }

        private void btnCopyHex_Click(object sender, EventArgs e)
        {
            if (listRecent.SelectedIndex != -1)
            {
                if (listRecent.Text.EndsWith("]"))
                {
                    int a = listRecent.Text.LastIndexOf("[");
                    Clipboard.Clear();
                    string tmp = listRecent.Text.Substring(a + 1, listRecent.Text.Length - 2 - a);
                    if (tmp.Contains(" "))
                        Clipboard.SetDataObject(tmp);
                    else
                    {
                        byte[] bytaArray = System.Text.Encoding.ASCII.GetBytes(tmp);
                        tmp = "";
                        for (int i = 0; i < bytaArray.Length; ++i)
                        {
                            if (i != 0)
                                tmp += " ";
                            tmp += bytaArray[i].ToString("X2");
                        }
                        Clipboard.SetDataObject(tmp);
                    }
                }
            }
        }

        #endregion

        #region 作为客户端Client

        Socket clientSocket = null;
        //连接
        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textClientIP.Text.Length == 0)
                {
                    MessageBox.Show("IP地址不许为空！");
                    return;
                }
                if (textClientPort.Text.Length == 0)
                {
                    MessageBox.Show("端口号不许为空！");
                    return;
                }
                printToWin("连接服务器"+ textClientIP.Text + ":" + textClientPort.Text +"中...");
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ip = IPAddress.Parse(textClientIP.Text);
                IPEndPoint point = new IPEndPoint(ip, Int32.Parse(textClientPort.Text));

                clientSocket.Connect(point);
                if (clientSocket.Connected == false)
                    throw new Exception();

                Thread receiveThread = new Thread(onReceiveData);
                receiveThread.IsBackground = true;
                receiveThread.Start(clientSocket);

                btnStart.Enabled = false;
                btnStop.Enabled = false;
                activeDisconn = false;
                printToWin("连接服务器" + textClientIP.Text + ":" + textClientPort.Text + "成功！");
            }
            catch
            {
                printToWin("连接服务器" + textClientIP.Text + ":" + textClientPort.Text + "失败！");
            }
        }

        //是否主动断开了与服务器的连接
        bool activeDisconn = false;
        private void btnDisconn_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Close();

                activeDisconn = true;
                btnStart.Enabled = true;
                btnStop.Enabled = true;
                printToWin("(主动)断开服务器" + textClientIP.Text + ":" + textClientPort.Text + "成功！");
            }
            catch
            {
                printToWin("(主动)断开服务器" + textClientIP.Text + ":" + textClientPort.Text + "失败！");
            }
        }

        #endregion

    }
}
