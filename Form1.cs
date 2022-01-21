using System.Diagnostics;

namespace NEUTRINO_GUIs
{
    public partial class Form1 : Form
    {
        string whereRun;
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
            //�I�����ꂽRun�t�@�C�������s
            MessageBox.Show("���s���J�n����܂����B");
            Command(fileNameR);
            MessageBox.Show("Done");

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
            string  fileNameR = Path.GetFileNameWithoutExtension(whereRun);
            string[] lines = File.ReadAllLines(whereRun);
            //Run�t�@�C��������������
            bool streamWriterOption = false;
            string scoreFileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            StreamWriter sw = new StreamWriter(whereRun, streamWriterOption);
            for (int a = 0; a < 5; a++)
            {
                sw.WriteLine(lines[a]);
            }
            //BASENAME�̍s����������
            sw.WriteLine("set BASENAME = " + scoreFileName);

            //�c��̍s����������
            for (int b = 6; b < lines.Length; b++)
            {
                sw.WriteLine(lines[b]);
            }
            sw.Close();

            scorefile.Text = scoreFileName;
            MessageBox.Show("�t�@�C���I�����������܂����B");
        }

        private void runFileSellect_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "�o�b�`�t�@�C��(*.bat)|*.bat|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Run�t�@�C���I��";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "Run.bat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
            }

            whereRun = openFileDialog1.FileName;
            whereRunfile.Text = openFileDialog1.FileName;
            MessageBox.Show("�t�@�C���I�����������܂����B");
        }

    }
}