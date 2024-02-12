﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlmoOS
{
    public partial class AdministradorTareas : Form 
{
    public AdministradorTareas() 
    { 
        InitializeComponent();
        UpdateProcessList();
        timer1.Enabled = true;
    }
    private void UpdateProcessList() {
        lstProcesses.Items.Clear();
        lst_id.Items.Clear();
        lst_memoriafisica.Items.Clear();
        lst_memoriavirtual.Items.Clear();
        lst_CPU.Items.Clear();
        int id = 1;
        foreach (Process p in Process.GetProcesses()) 
        {
            lstProcesses.Items.Add(id + ":" + p.ProcessName); // nombre del proceso
            lst_id.Items.Add(id + ": " + p.Id);// id del proceso
            lst_memoriafisica.Items.Add(id + ": " + p.WorkingSet64);// RAM del proceso
            lst_memoriavirtual.Items.Add(id + ": " + p.VirtualMemorySize64); // MEmoria virtual del proceso
            lst_CPU.Items.Add(id + ": " + p.SessionId); // CPU que usa el proceso
           
            id = id + 1;     
        }
        tslProcessCount.Text = "Procesos Actuales: " + lstProcesses.Items.Count.ToString();    //  cant de procesos   
    } 
        
private void btnKill_Click(object sender, EventArgs e) {

    try
    {
        foreach (Process p in Process.GetProcesses())
        {
            string arr = lstProcesses.SelectedItem.ToString(); // proceso seleccionado en el list box
            string[] proceso = arr.Split(':');// divido el contenido del listbox
 

            if (p.ProcessName == proceso[1])
            {
                p.Kill(); // elimina el proceso
            }
           
        }
    }
    catch (Exception x){
        MessageBox.Show("no selecciono nigun proceso " + x,"error al eliminar",MessageBoxButtons.OK);
    }
   
    //UpdateProcessList(); 
} 

        
        private void button1_Click(object sender, EventArgs e) { 
            Close(); 
        } 
        private void button2_Click(object sender, EventArgs e) {
            MessageBox.Show("Realizado por Joseph Almonte", "Info del grupo", MessageBoxButtons.OK); 
        }

        private void btnUpdateProcessList_Click_1(object sender, EventArgs e)
        {
         UpdateProcessList(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessList(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictBoxMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
