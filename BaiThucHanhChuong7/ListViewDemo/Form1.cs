﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                cbDrive.Items.Add(drive);
            }
            cbDrive.SelectedIndex = 0;
        }

        private void cbDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddItemToListView(cbDrive.SelectedItem.ToString());
        }

        string FormatFileSize(long fileSize)
        {
            if (fileSize < 1024)
            {
                return string.Format("{0} Byte", fileSize); // Byte
            }
            else if (((double)fileSize / 1024) < 1024)
            {
                return string.Format("{0:0.##} KB", (double)fileSize / 1024); // KB
            }
            else if (((double)fileSize / (1024 * 1024)) < 1024)
            {
                return string.Format("{0:0.##} MB", (double)fileSize / (1024 * 1024)); // MB
            }
            return string.Format("{0:0.##} GB", (double)fileSize / (1024 * 1024 * 1024)); // GB
        }

        void AddItemToListView(string path)
        {
            lvDrive.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (DirectoryInfo subFolder in folder.GetDirectories())
            {
                ListViewItem listViewItem = new ListViewItem(subFolder.Name)
                {
                    Tag = subFolder,
                    ImageIndex = 0
                };
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(Directory.GetLastWriteTime(subFolder.FullName).ToString());
                lvDrive.Items.Add(listViewItem);
            }
            foreach (FileInfo file in folder.GetFiles())
            {
                ListViewItem listViewItem = new ListViewItem(file.Name)
                {
                    Tag = file,
                    ImageIndex = 1
                };
                listViewItem.SubItems.Add(FormatFileSize(file.Length));
                listViewItem.SubItems.Add(Directory.GetLastWriteTime(file.FullName).ToString());
                lvDrive.Items.Add(listViewItem);
            }
        }

        private void lvDrive_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = lvDrive.SelectedItems[0].Tag;
                if (selectedItem is DirectoryInfo directoryInfo)
                {
                    AddItemToListView(directoryInfo.FullName);
                }
                else if (selectedItem is FileInfo fileInfo)
                {
                    Process.Start(fileInfo.FullName);
                }
            }
            catch
            {

            }
        }

        private void lvDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrive.SelectedItems.Count > 0)
            {
                var selectedItem = lvDrive.SelectedItems[0].Tag;
                if (selectedItem is DirectoryInfo directoryInfo)
                {
                    lbPath.Text = directoryInfo.FullName;
                }
                else if (selectedItem is FileInfo fileInfo)
                {
                    lbPath.Text = fileInfo.FullName;
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            switch (radioButton.Text)
            {
                case "List":
                    lvDrive.View = View.List;
                    break;
                case "Details":
                    lvDrive.View = View.Details;
                    break;
                case "LargeIcon":
                    lvDrive.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    lvDrive.View = View.SmallIcon;
                    break;
                case "Tile":
                    lvDrive.View = View.Tile;
                    break;
            }
        }


    }
}
