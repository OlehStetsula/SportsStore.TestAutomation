using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Expression.Encoder.ScreenCapture;
using System.Drawing;
using System.Windows;
using System.IO;
using Accord.Video;
using Accord.Video.VFW;

namespace SportsStore.TestAutomation.BasicTools
{
    public class VideoRecorder
    {
        //private static readonly ScreenCaptureJob vidRec = new ScreenCaptureJob();
        //private static readonly Process ffmpegProcess;
        private Accord.Video.ScreenCaptureStream stream;

        public void StartRecordingVideo(string scenarioTitle)
        {
            Rectangle screenArea = Rectangle.Empty;
            foreach (System.Windows.Forms.Screen screen in
                      System.Windows.Forms.Screen.AllScreens)
            {
                screenArea = Rectangle.Union(screenArea, screen.Bounds);
            }

            string videoPath = "C://" + "\\video\\" + DateTime.Now.Date.ToShortDateString();
            DirectoryInfo dir = new DirectoryInfo(videoPath);
            //записи хранятся рассортированными по папкам с датой в названии
            if (!dir.Exists)//проверяем, есть ли уже папка с сегодняшней датой
                dir.Create(); //если нет, то создаем ее
            videoPath = "C://" + "\\video\\" + DateTime.Now.Date.ToShortDateString() +  ".avi"; //если есть, то добавим порядковый номер
            // create screen capture video source
            stream = new ScreenCaptureStream(screenArea);

            // set NewFrame event handler
           //stream.NewFrame += new NewFrameEventHandler(video_NewFrame);

            // start the video source
            //stream.Start();

            stream.NewFrame += new Accord.Video.NewFrameEventHandler(video_NewFrame);
            try
            {
                //VideoFileWriter writer = new VideoFileWriter();
                //writer.FrameRate = 25;
                //writer.Quality = 1;
                //writer.Open(videoPath, screenArea.Width, screenArea.Height);
                stream.Start();
            }
            catch (Exception e) {  }

        }
         
        public void EndRecording()
        {
            stream.SignalToStop( );
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            //Bitmap bitmap = eventArgs.Frame;
            // process the frame
        }
    }
}
    