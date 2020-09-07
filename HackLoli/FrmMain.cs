using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HackLoli
{
    public partial class FrmMain : Form
    {
        public FrmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// 确定按钮开始捆绑文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e) {
            //保存路径是空则还有必要项没选择
            if (string.IsNullOrEmpty(txtCSave.Text)) {
                MessageBox.Show("路径资料填写不完整！");
            } else {
                try {
                    //检查将要新建的文件是否已有重名文件，有则删除
                    if (File.Exists(txtCSave.Text)) {
                        File.Delete(txtCSave.Text);
                    }
                    string tofileZip = Application.StartupPath + "\\" + Path.GetFileNameWithoutExtension(txtBFile.Text) + ".zip";
                    FileToZip(txtBFile.Text, tofileZip);
                    //创建一个进程操作
                    Process p = new Process();
                    //设置要启动的应用程序或文档，启动CMD
                    p.StartInfo.FileName = "cmd.exe";
                    //不使用操作系统外壳程序启动进程。
                    p.StartInfo.UseShellExecute = false;
                    //设置应用程序的输入是从 System.Diagnostics.Process.StandardInput 流中读取。
                    p.StartInfo.RedirectStandardInput = true;
                    //设置应用程序的输出写入 System.Diagnostics.Process.StandardOutput 流中。
                    p.StartInfo.RedirectStandardOutput = true;
                    //设置应用程序的错误输出写入 System.Diagnostics.Process.StandardError 流中。
                    p.StartInfo.RedirectStandardError = true;
                    //在新窗口中启动该进程的值。
                    p.StartInfo.CreateNoWindow = true;
                    //启用进程组件
                    p.Start();
                    string strOutput = null;
                    //写入应用程序的流，这里写的是复制捆绑文件的CMD命令
                    p.StandardInput.WriteLine(string.Format("copy /b {0}+{1} {2}", txtAFile.Text, tofileZip, txtCSave.Text));
                    //执行完这句后退出CMD
                    p.StandardInput.WriteLine("exit");
                    //截获应用程序输出的流
                    strOutput = p.StandardOutput.ReadToEnd();
                    //显示在文本框中
                   // txtMsg.AppendText(strOutput);
                    //进程操作类开始等待进程退出
                    p.WaitForExit();
                    //关闭进程
                    p.Close();
                    File.Delete(tofileZip);
                    MessageBox.Show("捆绑成功！");
                } catch (Exception ex) {
                   MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 选择捆绑文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFile_Click(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txt.Text = openFile.FileName;
                txt.Tag = Path.GetExtension(openFile.FileName);
            }
        }

        //选择保存路径
        private void txtCSave_Click(object sender, EventArgs e) {
            //判断是否主文件与副文件已经选择
            if (txtAFile.Tag != null && txtBFile.Tag != null) {
                saveFile.Filter = txtAFile.Tag.ToString().Trim('.').ToUpper() + " 文件|*" + txtAFile.Tag + "|" +
                                txtBFile.Tag.ToString().Trim('.').ToUpper() + " 文件|*" + txtBFile.Tag;
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    txtCSave.Text = saveFile.FileName;
                }
            } else {
                MessageBox.Show("请先选择有效的主文件和副文件！");
            }
        }

        /// <summary>
        /// 将文件压缩成Zip
        /// </summary>
        /// <param name="path">要压缩的文件</param>
        /// <param name="address">压缩后zip路径</param>
        private void FileToZip(string path, string address) {
            string name = Path.GetFileName(path);
            FileStream StreamToZip = new FileStream(path, FileMode.Open, FileAccess.Read);
            FileStream ZipFile = File.Create(address);
            ZipOutputStream ZipStream = new ZipOutputStream(ZipFile);
            //压缩文件
            ZipEntry ZipEntry = new ZipEntry(name);
            ZipStream.PutNextEntry(ZipEntry);
            ZipStream.SetLevel(6);
            byte[] buffer = new byte[StreamToZip.Length];
            StreamToZip.Read(buffer, 0, Convert.ToInt32(StreamToZip.Length));
            ZipStream.Write(buffer, 0, Convert.ToInt32(StreamToZip.Length));
            ZipStream.Finish();
            ZipStream.Close();
            StreamToZip.Close();
        }

    }
}
