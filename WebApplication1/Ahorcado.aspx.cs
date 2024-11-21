using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Ahorcado : System.Web.UI.Page
    {
        private static string palabraSecreta;
        private static char[] frase;
        private static int Intentos = 6;
        private static List<char> intentosLetra = new List<char>();
        private static bool acierto;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StartGame();
                panelAhoracado.Visible = true;
            }
                
            
        }

        private void StartGame()
        {
            List<string> palabra = new List<string>
            {
                "manzana",
                "coche",
                "espantapajaros",
                "Pikachu",
                "ahoracado"
            };

            Random rand = new Random();
            palabraSecreta = palabra[rand.Next(palabra.Count)];

            frase = new string('_',palabraSecreta.Length).ToCharArray();
            Intentos = 6;
            intentosLetra.Clear();

            lblPalabraOculta.Text = new string(frase);
            lblIntentos.Text = "Intentos restantes: " + Intentos;



        }

        protected void btnGuess_Click(object sender, EventArgs e)
        {
            acierto = false;
            string input = txtLetra.Text.ToLower();
            if(input.Length != 1 || intentosLetra.Contains(input[0]))
            {
                lblMessage.Text = "Ingrese una letra valida y no repetida";
                return;
            }

            char letrasAdivinadas = input[0];
            intentosLetra.Add(letrasAdivinadas);

            if (palabraSecreta.Contains(letrasAdivinadas))
            {
                //Reemplazar los guiones por letras acertadas
                for (int i = 0; i < palabraSecreta.Length; i++)
                {
                    if(palabraSecreta[i] == letrasAdivinadas)
                    {
                        frase[i] = letrasAdivinadas;
                        acierto = true;
                    }
                        
                }
            }

            lblPalabraOculta.Text = new string(frase);

            //verificar si gano
            if (!new string(frase).Contains('_'))
            {
                lblMessage.Text = "Ganaste";
                DisableInputs();
            }
            else
            {
                //reducir intentos
                if(!acierto)
                    Intentos--;

                lblIntentos.Text = "Intentos restantes: " + Intentos;

                ActualizarMonigote(Intentos);

                if (Intentos == 0)
                {
                    lblMessage.Text = "¡PERDISTE! La palabra era " + palabraSecreta;
                    DisableInputs();
                }
            }

            txtLetra.Text = "";

        }

        private void ActualizarMonigote(int intentosPerdidos)
        {
            cabeza.Visible = false;
            cuerpo.Visible = false;
            brazoIzq.Visible = false;
            brazoDer.Visible = false;
            piernaIzq.Visible = false;
            piernaDer.Visible = false;

            // Mostrar las partes dependiendo del número de fallos
            switch (intentosPerdidos)
            {
                case 5: cabeza.Visible = true; break;
                case 4: cuerpo.Visible = true; break;
                case 3: brazoIzq.Visible = true; break;
                case 2: brazoDer.Visible = true; break;
                case 1: piernaIzq.Visible = true; break;
                case 0: piernaDer.Visible = true; break;
            }
        }

        private void DisableInputs()
        {
            txtLetra.Enabled = false;
            btnAdivinar.Enabled = false;
        }

        protected void btnRestart_Click(object sender, EventArgs e)
        {
            StartGame();
            txtLetra.Enabled=true;
            btnAdivinar.Enabled=true;
            lblMessage.Text = "";
        }
    }
}