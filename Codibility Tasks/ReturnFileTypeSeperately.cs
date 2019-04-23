using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codibility_Tasks
{
    class ReturnFileTypeSeperately
    {
        public static string returnFileTypeSeperately(string S)
        {
            double music = 0;
            double image = 0;
            double movie = 0;
            double other = 0;

            using (StringReader sr = new StringReader(S))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var lines = line.Split(' ');
                    var fileType = lines[0].Split('.').Last();
                    var fileSize = Convert.ToInt32(lines[1].Remove(lines[1].Length - 1, 1));

                    if (Enum.IsDefined(typeof(MusicFileExtention), fileType))
                    {
                        music = music + fileSize;
                    }

                    else if (Enum.IsDefined(typeof(ImageFileExtention), fileType))
                    {
                        image = image + fileSize;
                    }

                    else if (Enum.IsDefined(typeof(MovieFileExtention), fileType))
                    {
                        movie = movie + fileSize;
                    }

                    else other = other + fileSize;
                }
            }
            var fs = string.Format("music {0}b\r\nimage {1}b\r\nmovie {2}b\r\nother {3}b\r\n", music, image, movie, other);
            return fs;
        }
        public enum MusicFileExtention
        {
            
            mp3,
            aac,
            flac,
        }
        public enum ImageFileExtention
        {
            jpg,
            bmp,
            gif,
        }
        public enum MovieFileExtention
        {
            mp4,
            avi,
            mkv,
        }

    }
}
