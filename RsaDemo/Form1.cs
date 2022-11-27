using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsaDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ulong _P, _Q; // параметры алгоритма, простые числа. не используются в качестве ключей, но являются основой для определения закрытого ключа
        ulong _M;     // модуль, = P * Q , элемент открытого ключа
        ulong _ek, _dk; // пара ключей (открытый и закрытый). Один из них подбирается - любое взаимопростое со значением функции Эйлера от M, т.е. с (P-1) * (Q-1) 
                        // другой вычисляется -  обратное к первому ключу по модулю F (  по модулю функции Эйлера от M ( F=(P-1)*(Q-1) )  )

        ulong _encryptedMessage; // зашифрованное сообщение - исходное сообщение в степени открытого ключа по модулю M (либо в случае использования в сценарии подтверждения подписи - в степени закрытого ключа)
        ulong _decrypteddMessage; // восстановленное исходное сообщение - зашифрованное сообщение в степени другого ключа пары (закрытого, или же открытого в противоположном сценарии)


        MessagingSide _alice = new MessagingSide();
        MessagingSide _bob = new MessagingSide();


        private void btnKeys_Click(object sender, EventArgs e)
        {
            if (!ulong.TryParse(txtP.Text, out _P))
            {
                MessageBox.Show("P");
                return;
            }
            if (!ulong.TryParse(txtQ.Text, out _Q))
            {
                MessageBox.Show("Q");
                return;
            }

            if (!ulong.TryParse(txtE.Text, out _ek))
            {
                MessageBox.Show("e");
                return;
            }

            // вычисление закрытого ключа d
            ulong f = (_P - 1) * (_Q - 1);
            ulong d = MathOperations.Inverse1(_ek, f);
       
            if (d == 0)
            {
                MessageBox.Show("выбранный открытый ключ E и функция Эйлера от m (т.е. (p-1)*(q-1)) - не взаимопросты, нужно подобрать другой ключ");
                txtD.Text = "";
            }
            else
            {
                _dk = d ;
                txtD.Text = _dk.ToString();
            }

        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            TryUpdateM();
        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            TryUpdateM();
        }

        private bool TryUpdateM()
        {
            if (!ulong.TryParse(txtP.Text, out _P))
            {                
                return false;
            }
            if (!ulong.TryParse(txtQ.Text, out _Q))
            {                
                return false;
            }

            // проверка на простоту P и Q
            // .......



            _M = _P * _Q;
            txtM.Text = _M.ToString();
            
            ulong F = (_P - 1) * (_Q - 1);
            txtF.Text = F.ToString();

            return true;



        }

        private void txtP0_TextChanged(object sender, EventArgs e)
        {
            txtG.Text = "";
            lblCheck.Text = "";
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            ulong p,g;
            if (!ulong.TryParse(txtP0.Text, out p))
            {
                return;
            }
            if (!ulong.TryParse(txtG.Text, out g))
            {                
                return;
            }

            if (!MathOperations.IsPrimitiveRootOfPrime(g, p))
            {
                lblCheck.Text = $"Введенное число не является первообразным корнем для {txtP0.Text}";   
            }
            else
                lblCheck.Text = "";
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            ulong p, g;
            if (!ulong.TryParse(txtP0.Text, out p))
            {
                MessageBox.Show("p");
                return;
            }
           
            if (!ulong.TryParse(txtG.Text, out g))
            {
                MessageBox.Show("g");
                return;
            }

            _alice.CreateSession(_bob, p, g);

            txtK1.Text = _alice.K.ToString();
            txtGS1.Text = _alice.GS.ToString();
            txtKey1.Text = _alice.Key.ToString();

            txtK2.Text = _bob.K.ToString();
            txtGS2.Text = _bob.GS.ToString();
            txtKey2.Text = _bob.Key.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ulong msg;
            if (!ulong.TryParse(txtMsg1.Text, out msg))
            {
                MessageBox.Show("msg");
                return;
            }

            ulong emsg = _alice.Encrypt(msg);
            ulong dmsg = _bob.Decrypt(emsg);
           
            txtEnMsg1.Text = emsg.ToString();
            txtMsg2.Text = dmsg.ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            ulong message;
            if (!ulong.TryParse(txtMessage.Text, out message))
            {
                MessageBox.Show("message");
                return;
            }

            _encryptedMessage = MathOperations.Pow(message, _ek, _M);
            txtEncr.Text = _encryptedMessage.ToString();

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            _decrypteddMessage = MathOperations.Pow(_encryptedMessage, _dk, _M);
            txtDecr.Text = _decrypteddMessage.ToString();
        }
    }
}
