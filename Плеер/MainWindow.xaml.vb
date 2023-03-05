Using System;
Using System.Collections.Generic;
Using System.Ling;
Using System.Text;
Using System.Threading.Tasks;
Using System.Windows;
Using System.Windows.Data;
Using System.Windows.Documents;
Using System.Windows.Input;
Using System.Windows.Media;
Using System.Windows.Media.Imaging;
Using System.Windows.Novigation;
Using System.Windows.Shapes;

Namespace Music
{
    Public partical Class MainWindow : Window
    {
        Public MainWindow()
        {
            InitializeComponent();
        }
        MediaPlayer mediaplayer = New MediaPlayer();
        String filename;

        Private void BT_Click_Open(Object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = New OpenFileDialog
            {
                Multiselect = false,
                DefaulteExt = ".mp3"
            };
            bool? dealogOk = fileDialog.FileName;
            If (dealogOk == True)
            {
                filename = fileDialog.FileName;
                TBFileName.Text = filenDialog.safeFileName;
                mediaPlayer.Open(New Uri(filename));
            }
        }

        Private void BT_Click_Play(Object sender, RoutedEventArgs e)
        {
            mediaplayer.Play();
        }

        Private void BT_Click_Play(Object sender, RoutedEventArgs e)
        {
            mediaplayer.Pause();
        }

        Private void BT_Click_Play(Object sender, RoutedEventArgs e)
        {
            mediaplayer.Stop();
        }
    }
}