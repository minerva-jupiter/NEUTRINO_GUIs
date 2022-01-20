using System.Diagnostics;

namespace NEUTRINO_GUIs
{
    public partial class Form1 : Form
    {
        public void Command(string command)
        {
            //引数を代入
            ProcessStartInfo processStartInfo = new ProcessStartInfo(command);

            //新しいタブができないように設定。
            processStartInfo.CreateNoWindow = true;

            //標準出力を取得。
            processStartInfo.RedirectStandardOutput = true;

            //実行
            Process process = Process.Start(processStartInfo);

            //終了を待って閉じる。
            process.WaitForExit();
            process.Close();

            MessageBox.Show("Done");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RUN_Click(object sender, EventArgs e)
        {
            string fileNameR = whereRunfile.Text;
            //親ファイルに移動
            Command(fileNameR);


        }

        private void 楽譜ファイル選択_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "musicxml (*.musicxml)|*.musicxml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = "楽譜ファイル選択";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = "sample1.musicxml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
            }

            //配列に代入
            string[] lines = File.ReadAllLines("../Run.bat");
            //Runファイルを書き換える
            bool streamWriterOption = false;
            string fileName = openFileDialog.FileName;
            StreamWriter sw = new StreamWriter(fileName, streamWriterOption);
            for (int a = 0; a < 5; a++)
            {
                sw.WriteLine(lines[a]);
            }
            //BASENAMEの行を書き換え
            sw.WriteLine("set BASENAME = " + openFileDialog);

            //残りの行を書き換え
            for (int b = 6; b < lines.Length; b++)
            {
                sw.WriteLine(lines[b]);
            }
            sw.Close();

            scorefile.Text = fileName;
            MessageBox.Show("ファイル選択が完了しました。");
        }

        private void runFileSellect_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "バッチファイル(*.bat)|*.bat|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "Runファイル選択";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "sample1.musicxml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
            }

            whereRunfile.Text = openFileDialog1.FileName;
            MessageBox.Show("ファイル選択が完了しました。");
        }

    }
}