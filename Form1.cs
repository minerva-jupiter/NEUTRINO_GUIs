using System.Diagnostics;

namespace NEUTRINO_GUIs
{
    public partial class Form1 : Form
    {
        public void Command(string command)
        {
            //��������
            ProcessStartInfo processStartInfo = new ProcessStartInfo(command);

            //�V�����^�u���ł��Ȃ��悤�ɐݒ�B
            processStartInfo.CreateNoWindow = true;

            //�W���o�͂��擾�B
            processStartInfo.RedirectStandardOutput = true;

            //���s
            Process process = Process.Start(processStartInfo);

            //�I����҂��ĕ���B
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
            //�e�t�@�C���Ɉړ�
            Command(fileNameR);


        }

        private void �y���t�@�C���I��_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "musicxml (*.musicxml)|*.musicxml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = "�y���t�@�C���I��";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = "sample1.musicxml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
            }

            //�z��ɑ��
            string[] lines = File.ReadAllLines("../Run.bat");
            //Run�t�@�C��������������
            bool streamWriterOption = false;
            string fileName = openFileDialog.FileName;
            StreamWriter sw = new StreamWriter(fileName, streamWriterOption);
            for (int a = 0; a < 5; a++)
            {
                sw.WriteLine(lines[a]);
            }
            //BASENAME�̍s����������
            sw.WriteLine("set BASENAME = " + openFileDialog);

            //�c��̍s����������
            for (int b = 6; b < lines.Length; b++)
            {
                sw.WriteLine(lines[b]);
            }
            sw.Close();

            scorefile.Text = fileName;
            MessageBox.Show("�t�@�C���I�����������܂����B");
        }

        private void runFileSellect_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "�o�b�`�t�@�C��(*.bat)|*.bat|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "Run�t�@�C���I��";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "sample1.musicxml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
            }

            whereRunfile.Text = openFileDialog1.FileName;
            MessageBox.Show("�t�@�C���I�����������܂����B");
        }

    }
}