﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public static class Util
    {
        public static string titulo = "SAERP Informa";
        public static string sucesso = "Registro Gravado com Sucesso!";
        public static string erro = "Não Foi Possivel Gravar o Registro!\n ERRO: ";


        public static void HabilitaCampos(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //verifico se for o campo entra e atribui TRUE na propriedade enabled
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = true;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = true;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Enabled = true;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Enabled = true;
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Enabled = true;
                }

            }
        }

        /// <summary>
        /// Metodo Responsavel por desabilitar os controles do formulario
        /// </summary>
        /// <param name="controles"></param>
        public static void DesabilitaCampos(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //verifico se for o campo entra e atribui false na propriedade enabled
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = false;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Enabled = false;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Enabled = false;
                }
            }
        }

        /// <summary>
        /// Metodo Responsavel por limpar todos textbox do formulario
        /// </summary>
        /// <param name="controles"></param>
        public static void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //verifico se for o campo entra e atribui false na propriedade enabled
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = 0;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Text = "";
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }


            }
        }

        /// <summary>
        /// Metodo para gerar ukey ramdomica de tamanho 20
        /// </summary>
        /// <returns>senha</returns>
        public static string GerarUkey()
        {
            int Tamanho = 20; // Numero de digitos da senha
            string senha = string.Empty;
            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha.ToUpper();
        }
        //desabilita os botoes do forme
        public static void DesabilitaBotoes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //verifico se for o campo entra e atribui false na propriedade enabled
                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = false;
                }
                else if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Enabled = false;
                }
            }
        }
        /// <summary>
        /// Metodo de habilita campos dentro de um tabControl ou tabpages
        /// </summary>
        /// <param name="ctrl"></param>
        public static void HabilitaCamposTabControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is NumericUpDown)
                {
                    c.Enabled = true;
                }
                else if (c is CheckBox)
                {
                    c.Enabled = true;
                }
                else if (c is DateTimePicker)
                {
                    c.Enabled = true;
                }
                else if (c is TextBox)
                {
                    c.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    c.Enabled = true;
                }
                else if (c is ComboBox)
                {
                    c.Enabled = true;
                }
                else if (c is MaskedTextBox)
                {
                    c.Enabled = true;
                }
                else if (c is Button)
                {
                    c.Enabled = true;
                }

                if (c.HasChildren)
                {
                    HabilitaCamposTabControl(c);
                }
            }
        }

        public static void DesabilitaCamposTabControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is NumericUpDown)
                {
                    c.Enabled = false;
                }
                else if (c is CheckBox)
                {
                    c.Enabled = false;
                }
                else if (c is DateTimePicker)
                {
                    c.Enabled = false;
                }
                else if (c is TextBox)
                {
                    c.Enabled = false;
                }
                else if (c is RadioButton)
                {
                    c.Enabled = false;
                }
                else if (c is ComboBox)
                {
                    c.Enabled = false;
                }
                else if (c is MaskedTextBox)
                {
                    c.Enabled = false;
                }

                if (c.HasChildren)
                {
                    DesabilitaCamposTabControl(c);
                }
            }
        }

        public static void HabilitaBotoesTabControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
                if (c.HasChildren)
                {
                    HabilitaBotoesTabControl(c);
                }
            }
        }
    }
}
