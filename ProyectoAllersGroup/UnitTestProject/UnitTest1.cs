﻿using System;
using System.Collections.Generic;
using Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        FIGeneration fIGeneration;

        Dictionary<String, int> esperados = new Dictionary<String, int>();
        

        public void setScene0()
        {
            esperados.Add("BREAD ", 4);
            esperados.Add("MILK ", 4);
            esperados.Add("DIAPERS ", 4);
            esperados.Add("BEER ", 3);
            esperados.Add("BREAD MILK ", 3);
            esperados.Add("BREAD DIAPERS ", 3);
            esperados.Add("MILK DIAPERS ", 3);
            esperados.Add("DIAPERS BEER ", 3);

            fIGeneration = new FIGeneration(60, true);//min support del 60%
            fIGeneration.FrequentItemGeneration(3);
            
        }
        [TestMethod]
        public void TestEjemploLibro()
        {
            setScene0();
            
            
            foreach (ItemSet candidatoFrecuente in fIGeneration.candidates)
            {
                String cadena = "";
                foreach (KeyValuePair<String, Item> i in candidatoFrecuente.items)
                {
                    cadena += i.Key + " ";
                                      
                }

                if (esperados.ContainsKey(cadena))
                {
                  Boolean op =  candidatoFrecuente.countSupport == esperados[cadena];
                  Assert.IsTrue(op);
                }
                else
                {
                    Assert.IsTrue(false);
                }

            }
            
            
        }
    }
}
