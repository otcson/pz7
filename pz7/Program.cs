using System;

namespace pz7
{
    enum processor {Intel, Amd}
    enum matplata {Esonic,Intel,Gigabyte,AsRock }
    enum videokarta {Asus, Gigabyte, Msi, PowerColor}
    class Computer
    {
        public processor proc;
        public matplata plata;
        public videokarta vkarta;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer My = new Computer();
            My.proc = processor.Amd;
            My.plata = matplata.Gigabyte;
            My.vkarta = videokarta.PowerColor;
        }
    }
}
