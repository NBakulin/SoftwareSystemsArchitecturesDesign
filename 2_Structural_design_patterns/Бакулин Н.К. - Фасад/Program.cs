using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    #region КлассКлиентаКоторомуНужноЧто-тоСделатьСВидеофайлом
    class Program
    {
    //Класс клиента
    //Клиент через фасад будет обращаться к видеофайлу, избавляясь от надобности знать особенности его реализации
        static void Main(string[] args)
        {
            VideoConversionFacade Facade = new VideoConversionFacade();
            Facade.convertVideo();
            String fileProcedures = Facade.getFile();
            Console.WriteLine(fileProcedures);
        }
    }
    #endregion КлассКлиентаКоторомуНужноЧто-тоСделатьСВидеофайлом

    #region КлассВидеофайлаККоторомуИдётДоступЧерезФасад
    //Класс видеофайла
    //Некая сущность видеофайла, с которой клиенту хорошо бы работать, работа пойдёт через фасад.
    public class VideoFile
    {
        private String name;
        private String procedures;

        public VideoFile(String name, String procedures)
        {
            this.name = name;
            this.procedures = procedures;
        }

        public void addProcedure(String newProcedure)
        {
            this.procedures += newProcedure;
        }

        public String getProcedure()
        {
            return this.procedures;
        }
    }
    #endregion КлассВидеофайлаККоторомуИдётДоступЧерезФасад

    #region КлассРаботающийСВидеофайлом
    //Класс, работающий с видеофайлом.
    //Он читает, что-то делает и пишет видеофайл
    public class BitrateReader
    {
        public static VideoFile read(VideoFile videoFile)
        {
            videoFile.addProcedure("BitrateReader: reading file...\n");
            return videoFile;
        }

        public static VideoFile DoSomething(VideoFile videoFile)
        {
            videoFile.addProcedure("BitrateReader: doing something with file...\n");
            return videoFile;
        }

        public static VideoFile convert(VideoFile videoFile)
        {
            videoFile.addProcedure("BitrateReader: writing file...");
            return videoFile;
        }
    }
    #endregion КлассРаботающийСВидеофайлом

    #region ФасадПредоставляющийКлиентуДоступКВидеофайлу
    //Класс фасада, работающий с видеофайлом и изолирующий клиента от реализации класса видеофайла.
    //В "боевом" проекте класс клиента будет лежать в другом пространстве имён и не будет иметь возможности доступа к видеофайлу.
    public class VideoConversionFacade
    {
        private VideoFile videoFile;
        public VideoFile convertVideo()
        {
            VideoFile videoFile = new VideoFile("fileOme", "");
            videoFile = BitrateReader.read(videoFile);
            videoFile = BitrateReader.DoSomething(videoFile);
            videoFile = BitrateReader.convert(videoFile);
            this.videoFile = videoFile;
            return videoFile;
        }

        public string getFile()
        {
            return videoFile.getProcedure();
        }
    }
    #endregion ФасадПредоставляющийКлиентуДоступКВидеофайлу
}
