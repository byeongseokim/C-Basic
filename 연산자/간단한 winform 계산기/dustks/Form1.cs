using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dustks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;  // 결과 값에 입력 방지
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 더하기
                label1.Text = "+"; // 버튼 클릭시 라벨을 + 로 변경
                /* int num1 = int.Parse(textBox1.Text);
                   int num2 = int.Parse(textBox2.Text);

                   int num3 = num1 + num2;*/
                // 텍스트 박스에서 입력한 것을 가져와서 double형식으로 변환(더 큰 숫자를 입력 받기 위해 double로 변경)
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                // 두 숫자를 더하여 결과 계산
                double num3 = num1 + num2;
                textBox3.Text = num3.ToString();
            }
            catch (FormatException) // 문자열을 다른 데이터 형식으로 변환 할 때 발생하는 오류를 처리 하기위해 사용 한다고 함
            {
                // 숫자를 입력 안하고 버튼 클릭시 발생
                MessageBox.Show("숫자를 입력해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 빼기
                label1.Text = "-"; // 버튼 클릭시 라벨을 - 로 변경
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                // 두 숫자(num1에서 num2)를 차감하여 결과 계산
                double num3 = num1 - num2;
                textBox3.Text = num3.ToString();
            }
            catch (FormatException)
            {
                // 숫자를 입력 안하고 버튼 클릭시 발생
                MessageBox.Show("숫자를 입력해주세요");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 곱
                label1.Text = "x"; // 버튼 클릭시 라벨을 x 로 변경
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                // 두 숫자를 곱하여 결과 계산
                double num3 = num1 * num2;
                textBox3.Text = num3.ToString();
            }
            catch (FormatException)
            {
                // 숫자를 입력 안하고 버튼 클릭시 발생
                MessageBox.Show("숫자를 입력해주세요");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // 몫
                label1.Text = "/"; // 버튼 클릭시 라벨을 / 로 변경
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                // 두 숫자를 나누어 몫을 구함
                double num3 = num1 / num2;
                textBox3.Text = num3.ToString();
            }
            catch (FormatException)
            {
                // 숫자를 입력 안하고 버튼 클릭시 발생
                MessageBox.Show("숫자를 입력해주세요");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 나머지
                label1.Text = "%"; // 버튼 클릭시 라벨을 % 로 변경
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                // 두 숫자를 나눈뒤 나머지를 구함
                double num3 = num1 % num2;
                textBox3.Text = num3.ToString();
            }
            catch (FormatException)
            {
                // 숫자를 입력 안하고 버튼 클릭시 발생
                MessageBox.Show("숫자를 입력해주세요");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 숫자 초기화
            // 입력 되어 있던 모든 텍스트 박스 빈칸으로 변경
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
