using System;
using System.Drawing;
using System.Windows.Forms;

namespace 抖音挺火的表白小软件
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        int bianliang = 0, x = 0, y = 0;
        Random rd = new Random();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Random rd = new Random();
            // int i = rd.Next(1,6);
           
            switch (i)
            {
                case 1:
                    MessageBox.Show("你的笑容没有酒，我却醉的像条狗~");
                    break;
                case 2:
                    MessageBox.Show("知道我和唐僧什么区别吗 唐僧取经我娶你~");
                    break;
                case 3:
                    MessageBox.Show("你会弹吉他吗？为什么拨动了我的心弦~");
                    break;
                case 4:
                    MessageBox.Show("你闻到空气中有烧焦的味道吗？那是我的心在为你燃烧~");
                    break;
                case 5:
                    MessageBox.Show("苦海无涯，回…回头是我呀~");
                    break;
                case 6:
                    MessageBox.Show("你现在不珍惜我，我告诉你，过了这个村，我在下个村等你。");
                    break;
                case 7:
                    MessageBox.Show("如果你不怕麻烦的话，可以麻烦喜欢我一下吗？");
                    break;
                case 8:
                    MessageBox.Show("这辈子跟我在一起吧，不行我就等等，再不行的话，我就想想别的办法。");
                    break;
                case 9:
                    MessageBox.Show("我想要去看一看你下辈子的命簿，看你下辈子娶到哪家，我便投胎到那家。");
                    break;
                case 10:
                    MessageBox.Show("你像一个人 ，我的女人");
                    break;
            }
            i++;
            if (i == 11) {
                i = 1;
            }
            if (bianliang != 1)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("❤❤❤么么哒❤❤❤");
            // bianliang = 1;
            //  this.Hide();
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            System.Environment.Exit(0);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            x = rd.Next(1, 350);
            y = rd.Next(1, 210);
            button2.Location = new Point(x, y);
        }
    }
}
