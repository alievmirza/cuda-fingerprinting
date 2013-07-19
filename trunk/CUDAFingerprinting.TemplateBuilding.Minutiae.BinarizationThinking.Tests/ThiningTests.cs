﻿using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CUDAFingerprinting.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUDAFingerprinting.TemplateBuilding.Minutiae.BinarizationThinking.Tests
{
    [TestClass]
    public class ThiningTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var img = ImageHelper.LoadImage(TestResource._104_6);
            var img = ImageHelper.LoadImage(TestResource.ThiningImageTest);
            var path = Path.GetTempPath() + "thininig.png";
            var thining = Thining.ThiningPicture(img);
            ImageHelper.SaveArray(thining, path);
            Process.Start(path);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //var img = ImageHelper.LoadImage(TestResource._104_6);
            var img = ImageHelper.LoadImage(TestResource.ThiningImageTest2);
            var path = Path.GetTempPath() + "thininig.png";
            var thining = Thining.ThiningPicture(img);
            ImageHelper.SaveArray(thining, path);
            Process.Start(path);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //var img = ImageHelper.LoadImage(TestResource._104_6);
            var img = ImageHelper.LoadImage(TestResource.ThiningImageTest3);
            var path = Path.GetTempPath() + "thininig.png";
            var thining = Thining.ThiningPicture(img); 
            ImageHelper.SaveArray(thining, path);
            Process.Start(path);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //var img = ImageHelper.LoadImage(TestResource._104_6);
            ImageHelper.SaveImageAsBinaryFloat("C:\\cuda-fingerprinting\\CUDAFingerprinting.TemplateBuilding.Minutiae.BinarizationThinking.Tests\\Resources\\104_61globalBinarization150.png", "C:\\temp\\104_6_Binarizated.bin");
            ImageHelper.SaveBinaryAsImage("C:\\temp\\104_6_BinarizatedThinnedCUDA.bin", "C:\\cuda-fingerprinting\\104_61globalBinarizatedthinnedCUDA.png", true);
            //ImageHelper.SaveIntArray();
            var img = ImageHelper.LoadImage(TestResource._104_61globalBinarization150);
            var path = Path.GetTempPath() + "thininig.png";
            var thining = Thining.ThiningPicture(img);
            ImageHelper.SaveArray(thining, path);
            Process.Start(path);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //var img = ImageHelper.LoadImage(TestResource._104_6);
            //var img = ImageHelper.LoadImage("C:\\Users\\CUDA Fingerprinting2\\picture.in");
            double[,] img = new double[,] 
                                    {{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                                     {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     }; 
            //var path = "C:\\Users\\CUDA Fingerprinting2\\" + "thininig.png";
            var thining = Thining.ThiningPicture(img);

            //var img1 = ImageHelper.LoadImage(TestResource.ThiningImageTest3);
            var img2 = ImageHelper.LoadImageAsInt(TestResource._104_61globalBinarization150); 
            
            for (int j = 0; j < img2.GetLength(0); j++)
            {
                for (int i = 0; i < img2.GetLength(1); i++)
                {
                    Console.Write(img2[j, i] + " ");
                }
                Console.WriteLine();
            }
            
            //for (int j = 0; j < thining.GetLength(0); j++)
            //{
            //    for (int i = 0; i < thining.GetLength(1); i++)
            //    {
            //        Console.Write(thining[j, i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Process.Start();
        }
        //[TestMethod]
        //public void TestMethod6()
        //{
        //    //var img = ImageHelper.LoadImage(TestResource._104_6);
        //    var img = ImageHelper.LoadImage(TestResource.TestCUDA);
        //    var path = Path.GetTempPath() + "thininig.png";
        //    var thining = Thining.ThiningPicture(img);
        //    ImageHelper.SaveArray(thining, path);
        //    Process.Start(path);
        //}

        [TestMethod]
        public void TestMethod6()
        {
            //var img = ImageHelper.LoadImage(TestResource._104_6);
            //ImageHelper.SaveImageAsBinaryFloat("C:\\cuda-fingerprinting\\CUDAFingerprinting.TemplateBuilding.Minutiae.BinarizationThinking.Tests\\Resources\\104_61globalBinarization150.png", "C:\\temp\\104_6_Binarizated.bin");
            ImageHelper.SaveBinaryAsImage("C:\\temp\\104_6_BinarizatedThinnedMinutiaeBigMatchedCUDA.bin", "C:\\temp\\104_6_BinarizatedThinnedMinutiaeBigMatchedCUDA.png", true);
            //ImageHelper.SaveIntArray();
            var img = ImageHelper.LoadImage(TestResource._104_61globalBinarization150);
            var path = Path.GetTempPath() + "thininig.png";
            var thining = Thining.ThiningPicture(img);
            ImageHelper.SaveArray(thining, path);
            Process.Start(path);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //var img = ImageHelper.LoadImage(TestResource._104_6);
            //ImageHelper.SaveImageAsBinaryFloat("C:\\cuda-fingerprinting\\CUDAFingerprinting.TemplateBuilding.Minutiae.BinarizationThinking.Tests\\Resources\\104_61globalBinarization150.png", "C:\\temp\\104_6_Binarizated.bin");
            ImageHelper.SaveBinaryAsImage("C:\\temp\\104_6_BinarizatedThinnedMinutiaeMatchedCUDA.bin", "C:\\temp\\104_6_BinarizatedThinnedMinutiaeMatchedCUDA.png", true);
            //ImageHelper.SaveIntArray();
            var img = ImageHelper.LoadImage(TestResource._104_61globalBinarization150);
            var path = Path.GetTempPath() + "thininig.png";
            var thining = Thining.ThiningPicture(img);
            ImageHelper.SaveArray(thining, path);
            Process.Start(path);
        }


    }
}
