using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace VENTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            const string connectionString = "mongodb+srv://Galaxia00ZemmA:NEV2416EFR@cluster0.vwjgpc2.mongodb.net/test";

            var client = new MongoClient(connectionString);

            var database = client.GetDatabase("Inventario");

            var collection = database.GetCollection<BsonDocument>("Ventas");

            var Ventas = new BsonDocument
            {
                {"ARTICULO" ,comboBox1.Text },
                {"CANTIDAD" ,textBox2.Text },
                {"PRECIO" ,textBox3.Text },
                {"CATEGORIA" ,comboBox2.Text },
                {"NO_FACTURA" ,textBox4.Text },
                {"CODIGO" ,comboBox3.Text },
                {"FECHA" ,textBox5.Text },

            };

            collection.InsertOne(Ventas);

            MessageBox.Show("Registro de Ventas: {0} guardado !!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

