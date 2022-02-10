using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pok89
{
    public partial class Form1 : Form
    {
    
        private Stack<int> cs = new Stack<int>();
        private readonly Random rnd = new Random();
        private string[,] Players;


        private string localpath = "D:\\source\\repos\\Pok89\\Pok89\\Resources";
        public Form1()
        {
            InitializeComponent();
        }

        private Image ByteToImage(string card)
        {
            //Card values:
            //          Ace| 2 | 3  | 4  | 5  | 6  | 7  | 8  | 9  | 10 |Jack|Queen|King
            //CLUBS:     0   4   8    12   16   20   24   28   32   36   40   44   48
            //DIAMONDS:  1   5   9    13   17   21   25   29   33   37   41   45   49
            //HEARTS:    2   6   10   14   18   22   26   30   34   38   42   46   50
            //SPADES:    3   7   11   15   19   23   27   31   35   39   43   47   51
            string CardName = string.Empty;
            switch (card)
            {
                case "0":
                    CardName = "clubs_A_60.gif";
                    break;
                case "1":
                    CardName = "diamonds_A_60.gif";
                    break;
                case "2":
                    CardName = "hearts_A_60.gif";
                    break;
                case "3":
                    CardName = "spade_A_60.gif";
                    break;
                case "4":
                    CardName = "clubs_2_60.gif";
                    break;
                case "5":
                    CardName = "diamonds_2_60.gif";
                    break;
                case "6":
                    CardName = "hearts_2_60.gif";
                    break;
                case "7":
                    CardName = "spade_2_60.gif";
                    break;
                case "8":
                    CardName = "clubs_3_60.gif";
                    break;
                case "9":
                    CardName = "diamonds_3_60.gif";
                    break;
                case "10":
                    CardName = "hearts_3_60.gif";
                    break;
                case "11":
                    CardName = "spade_3_60.gif";
                    break;
                case "12":
                    CardName = "clubs_4_60.gif";
                    break;
                case "13":
                    CardName = "diamonds_4_60.gif";
                    break;
                case "14":
                    CardName = "hearts_4_60.gif";
                    break;
                case "15":
                    CardName = "spade_4_60.gif";
                    break;
                case "16":
                    CardName = "clubs_5_60.gif";
                    break;
                case "17":
                    CardName = "diamonds_5_60.gif";
                    break;
                case "18":
                    CardName = "hearts_5_60.gif";
                    break;
                case "19":
                    CardName = "spade_5_60.gif";
                    break;
                case "20":
                    CardName = "clubs_6_60.gif";
                    break;
                case "21":
                    CardName = "diamonds_6_60.gif";
                    break;
                case "22":
                    CardName = "hearts_6_60.gif";
                    break;
                case "23":
                    CardName = "spade_6_60.gif";
                    break;
                case "24":
                    CardName = "clubs_7_60.gif";
                    break;
                case "25":
                    CardName = "diamonds_7_60.gif";
                    break;
                case "26":
                    CardName = "hearts_7_60.gif";
                    break;
                case "27":
                    CardName = "spade_7_60.gif";
                    break;
                case "28":
                    CardName = "clubs_8_60.gif";
                    break;
                case "29":
                    CardName = "diamonds_8_60.gif";
                    break;
                case "30":
                    CardName = "hearts_8_60.gif";
                    break;
                case "31":
                    CardName = "spade_8_60.gif";
                    break;
                case "32":
                    CardName = "clubs_9_60.gif";
                    break;
                case "33":
                    CardName = "diamonds_9_60.gif";
                    break;
                case "34":
                    CardName = "hearts_9_60.gif";
                    break;
                case "35":
                    CardName = "spade_9_60.gif";
                    break;
                case "36":
                    CardName = "clubs_10_60.gif";
                    break;
                case "37":
                    CardName = "diamonds_10_60.gif";
                    break;
                case "38":
                    CardName = "hearts_10_60.gif";
                    break;
                case "39":
                    CardName = "spade_10_60.gif";
                    break;
                case "40":
                    CardName = "clubs_j_60.gif";
                    break;
                case "41":
                    CardName = "diamonds_j_60.gif";
                    break;
                case "42":
                    CardName = "hearts_j_60.gif";
                    break;
                case "43":
                    CardName = "spade_j_60.gif";
                    break;
                case "44":
                    CardName = "clubs_q_60.gif";
                    break;
                case "45":
                    CardName = "diamonds_q_60.gif";
                    break;
                case "46":
                    CardName = "hearts_q_60.gif";
                    break;
                case "47":
                    CardName = "spade_q_60.gif";
                    break;
                case "48":
                    CardName = "clubs_k_60.gif";
                    break;
                case "49":
                    CardName = "diamonds_k_60.gif";
                    break;
                case "50":
                    CardName = "hearts_k_60.gif";
                    break;
                case "51":
                    CardName = "spade_k_60.gif";
                    break;
                default: 
                    CardName = "BackCard_60.gif";
                    break;
            }

            string PicturePath = Path.Combine(localpath, CardName);
            Bitmap Picture = new Bitmap(PicturePath);
            return Picture;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MeCard1.Image = null;
            MeCard2.Image = null;
            MeCard3.Image = null;
            DealerCard1.Image = null;
            DealerCard2.Image = null;
            DealerCard3.Image = null;
            btnBet.Enabled = true;
            //เตรียมไพ่ 
            cs.Clear();
            int card = rnd.Next(0, 52);
            do
            {
                while (!!cs.Contains(card))
                {
                    card = rnd.Next(0, 52);
                }
                cs.Push(card);
            }
            while (cs.Count != 52);

            //แจกไพ่
            Players = new string[9, 3];
            for (int i = 0; i < 2; i++)//ไฟ่ใบที่
            {
                for (int j = 0; j < 2; j++)//ผู้เล่นคนที่
                {
                    Players[j, i] = Convert.ToString(cs.Pop());
                }
            }
            MeCard1.Image = (Image)ByteToImage(Players[0, 0]);
            MeCard2.Image = (Image)ByteToImage(Players[0, 1]);
            DealerCard1.Image = (Image)ByteToImage(Players[1, 0]);
            DealerCard2.Image = (Image)ByteToImage(Players[1, 1]);

            lblMe1.Text = ((Convert.ToInt16(Math.Floor(Convert.ToDecimal(Players[0, 0]))) / 4) + 1).ToString();
            lblMe2.Text = ((Convert.ToInt16(Math.Floor(Convert.ToDecimal(Players[0, 1]))) / 4) + 1).ToString();

            lblDealer1.Text = ((Convert.ToInt16(Math.Floor(Convert.ToDecimal(Players[1, 0]))) /4) + 1).ToString();
            lblDealer2.Text = ((Convert.ToInt16(Math.Floor(Convert.ToDecimal(Players[1, 1]))) / 4) + 1).ToString();

            //Array.Clear(Seats, 0, 2);
            //for (int cardNo = 0; cardNo < 1; cardNo++)
            //{
            //     for (int Seat = 0; Seat < Seats.Length; Seat++)
            //    {
            //        Seats[Seat] = PlayerCards[Seat];
            //        PlayerCards[Seat] = Seats[Seat];
            //    }
            //}


            //var x = Seat.Length;
            //CurrentGame = cs.ToArray();

            //Dealer[0] = cs.Pop();
            //Me[0] = cs.Pop();
            //Dealer[1] = cs.Pop();
            //Me[1] = cs.Pop();

            //string ImagePath = Path.Combine(localpath, "BackCard_60.gif");
            //Bitmap image = new Bitmap(ImagePath);
            //DealerCard1.Image = (Image)ByteToImage(2);
            //DealerCard2.Image = (Image)ByteToImage(Dealer[1]);
            //MeCard1.Image = (Image)ByteToImage(Me[0]);
            //MeCard2.Image = (Image)ByteToImage(Me[1]);

            //Dealer[0] = 51;
            //หน้าไพ่
            //int x = (Dealer[0] % 4);
            //จำนวนแต้ม 
            //int y = Convert.ToInt32(Math.Floor(Convert.ToDecimal(Dealer[0]) / 4));

        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (Players[0, 2] == null)
            {
                Players[0, 2] = Convert.ToString(cs.Pop());
                MeCard3.Image = (Image)ByteToImage(Players[0, 2]);
                btnBet.Enabled = false;
            }

        }
    }
}
