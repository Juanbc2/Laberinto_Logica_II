using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaberintoLogicaII
{
    class checker
    {


        public checker(int[,] array2d)
        {
            Tuple<int, int> inicio = new Tuple<int, int>(0, 1);
            Tuple<int, int> final = new Tuple<int, int>(8, 12);
            Tuple<int, int> noRetorno = new Tuple<int, int>(-1, -1);
            int largo = 9, ancho = 13;
            Stack<Tuple<int, int>> pila = new Stack<Tuple<int, int>>();
            Stack<Stack<Tuple<int, int>>> resultados = new Stack<Stack<Tuple<int, int>>>();
            pila.Push(inicio);
            Console.WriteLine("----1");
            imprimirCamino(pilaToPila(recorrer1(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----2");
            imprimirCamino(pilaToPila(recorrer2(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----3");
            imprimirCamino(pilaToPila(recorrer3(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----4");
            imprimirCamino(pilaToPila(recorrer4(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----5");
            imprimirCamino(pilaToPila(recorrer5(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----6");
            imprimirCamino(pilaToPila(recorrer6(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----7");
            imprimirCamino(pilaToPila(recorrer7(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----8");
            imprimirCamino(pilaToPila(recorrer8(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----9");
            imprimirCamino(pilaToPila(recorrer9(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----10");
            imprimirCamino(pilaToPila(recorrer10(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----11");
            imprimirCamino(pilaToPila(recorrer11(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----12");
            imprimirCamino(pilaToPila(recorrer12(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----13");
            imprimirCamino(pilaToPila(recorrer13(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----14");
            imprimirCamino(pilaToPila(recorrer14(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----15");
            imprimirCamino(pilaToPila(recorrer15(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----16");
            imprimirCamino(pilaToPila(recorrer16(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----17");
            imprimirCamino(pilaToPila(recorrer17(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----18");
            imprimirCamino(pilaToPila(recorrer18(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----19");
            imprimirCamino(pilaToPila(recorrer19(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----20");
            imprimirCamino(pilaToPila(recorrer20(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----21");
            imprimirCamino(pilaToPila(recorrer21(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----22");
            imprimirCamino(pilaToPila(recorrer22(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----23");
            imprimirCamino(pilaToPila(recorrer23(array2d, pila, largo, ancho, inicio, noRetorno)));
            Console.WriteLine("----24");
            imprimirCamino(pilaToPila(recorrer24(array2d, pila, largo, ancho, inicio, noRetorno)));
        }

        public Stack<Tuple<int, int>> recorrer1(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {

            pila.Push(new Tuple<int, int>(0, 1));
            int i = 0;
            while (i < 50)
            {
                //mov arriba
                if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]+i);
                    i += 1;
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]+i);
                    i += 1;
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]+i);
                    i += 1;
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]+i);
                    i += 1;
                }

                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    Console.WriteLine("comp final 1");
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        Console.WriteLine("comp final 2");
                        return pila;

                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }


            }

            return null;
        }

        public Stack<Tuple<int, int>> recorrer2(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {
                //mov arriba
                if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer3(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {
                //mov arriba
                if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                    //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer4(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {
                //mov arriba
                if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer5(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {
                //mov arriba
                if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }
        public Stack<Tuple<int, int>> recorrer6(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {
                //mov arriba
                if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }


        public Stack<Tuple<int, int>> recorrer7(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov abajo
                if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }


        public Stack<Tuple<int, int>> recorrer8(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov abajo
                if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }



        public Stack<Tuple<int, int>> recorrer9(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov abajo
                if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }


        public Stack<Tuple<int, int>> recorrer10(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov abajo
                if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }


        public Stack<Tuple<int, int>> recorrer11(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov abajo
                if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer12(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov abajo
                if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                    //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer13(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {               //mov derecha
                if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer14(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov derecha
                if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer15(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov derecha
                if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer16(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov derecha
                if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }




                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }


        public Stack<Tuple<int, int>> recorrer17(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov derecha
                if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer18(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                  //mov derecha
                if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov izquierda
                else if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }




                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }


        public Stack<Tuple<int, int>> recorrer19(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov izquierda
                if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer20(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov izquierda
                if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer21(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov izquierda
                if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }

                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }


                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }

        public Stack<Tuple<int, int>> recorrer22(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov izquierda
                if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }



        public Stack<Tuple<int, int>> recorrer23(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov izquierda
                if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }



                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }


        public Stack<Tuple<int, int>> recorrer24(int[,] lab, Stack<Tuple<int, int>> pila, int largo, int ancho, Tuple<int, int> anterior, Tuple<int, int> noRetorno)
        {


            int i = 0;
            while (i < 50)
            {                //mov izquierda
                if (pila.Peek().Item2 != largo && lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 0 && pila.Peek().Item2 - 1 != anterior.Item2)
                {
                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 - 1)); i += 1;
                    //Console.WriteLine("izquierda" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov derecha
                else if (pila.Peek().Item2 != 0 && lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 0 && pila.Peek().Item2 + 1 != anterior.Item2)
                {

                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2 + 1)); i += 1;
                    //Console.WriteLine("derecha" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }                //mov abajo
                else if (pila.Peek().Item1 != ancho && lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 + 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 + 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("abajo" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }
                //mov arriba
                else if (pila.Peek().Item1 != 0 && lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 0 && pila.Peek().Item1 - 1 != anterior.Item1)
                {


                    anterior = new Tuple<int, int>(pila.Peek().Item1, pila.Peek().Item2);
                    pila.Push(new Tuple<int, int>(pila.Peek().Item1 - 1, pila.Peek().Item2)); i += 1;
                    //Console.WriteLine("arriba" + pila.Peek() + " " + lab[pila.Peek().Item1, pila.Peek().Item2]);
                }




                //-------------------------comprobar final-------------------------
                else if (pila.Peek().Item2 != largo && pila.Peek().Item2 != 0 && pila.Peek().Item1 != ancho && pila.Peek().Item1 != 0)
                {
                    if (lab[pila.Peek().Item1 - 1, pila.Peek().Item2] == 3 || lab[pila.Peek().Item1 + 1, pila.Peek().Item2] == 3
                        || lab[pila.Peek().Item1, pila.Peek().Item2 - 1] == 3 || lab[pila.Peek().Item1, pila.Peek().Item2 + 1] == 3)
                    {
                        //Console.WriteLine("comp final");
                        return pila;
                    }
                    else
                    {
                        //Console.WriteLine("desapilar");
                        noRetorno = pila.Pop();
                        anterior = noRetorno;
                    }
                }
                else
                {
                    //Console.WriteLine("desapilar");
                    noRetorno = pila.Pop();
                    anterior = noRetorno;
                }
            }
            return null;
        }







        public void imprimirCamino(Stack<Tuple<int, int>> pila)
        {
            Console.WriteLine("entra imp");
            if (pila != null)
            {
                foreach (Tuple<int, int> paso in pila)
                {
                    Console.WriteLine("(" + paso.Item1 + "," + paso.Item2 + ")");
                }
            }
            else
            {
                Console.WriteLine("Loop.");
            }
        }

        public Stack<Tuple<int, int>> pilaToPila(Stack<Tuple<int, int>> pila)
        {
            Console.WriteLine("entra pilatopila");
            if (pila != null)
            {
                Stack<Tuple<int, int>> pilaAux = new Stack<Tuple<int, int>>();
                foreach (Tuple<int, int> paso in pila)
                {
                    pilaAux.Push(paso);
                }
                return pilaAux;
            }

            return null;

        }

    }
}
