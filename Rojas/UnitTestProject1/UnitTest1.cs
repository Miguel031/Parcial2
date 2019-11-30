using System;
using Miguel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSave()
        {
            //organizar
            double proyecto1 = 10000;
            double salvar = 1000;
            double proyecto2 = 11000;
            string nombre = "Miguel";
            Company Obj = new Company(nombre, proyecto1);
            //actuar
            Obj.Save(salvar);
            double proyectoresultado = Obj.SaveProject;
            //afrimar
            Assert.AreEqual(proyecto2, proyectoresultado);
        }


        [TestMethod]
        public void TestSpend()
        {
            //organizar
            double proyecto1 = 10000;
            double spend = 1000;
            double proyecto2 = 9000;
            string nombre = "Miguel";
            Company Obj = new Company(nombre, proyecto1);
            //actuar
            Obj.Spend(spend);
            double proyectoresultado = Obj.SaveProject;
            //afrimar
            Assert.AreEqual(proyecto2, proyectoresultado);
        }
        [TestMethod]
        public void TestChangeName()
        {
            //organizar
            double proyecto = 10000;
            string nombreinicial = "Miguel";
            string nombrenuevo = "Andres";
            string nombreesperado = "Andres";
            Company name = new Company(nombreinicial, proyecto);
            //actuar
            name.ChangeName(nombrenuevo);
            string nombreresultado = name.Name;
            //afrimar
            Assert.AreEqual(nombreesperado, nombreresultado);
        }

    }
}
   
