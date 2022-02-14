using System;

namespace Prova1AP.ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x = 0, y = 0, z = 0, lineXY, lineXZ, lineZY, sumLineXYZY, sumLineXZZY, sumLineXYXZ;
            bool triangle = false, isNumeric = false;
            string option;

            Console.WriteLine("OLÁ, SEJA BEM VINDO AO SISTEMA DE VERIFICAÇÃO DE TRIÂNGULOS!!\n");
            do
            {
                Console.WriteLine("\n====================================================================");
                Console.WriteLine("\nDigite 1 para verificar o tipo do triângulo;");
                Console.WriteLine("Digite S para sair;");
                Console.Write(": ");
                option = Console.ReadLine();

                if (option == "s" || option == "S")
                {
                    Console.WriteLine("\n====================================================================");
                    Console.WriteLine("\nVOCÊ ESCOLHEU SAIR!!\n");
                    break;
                }
                else if (option == "1")
                {
                    Console.WriteLine("\n====================================================================");
                    Console.Write("** 1 - Informe o valor de X: ");
                    isNumeric = int.TryParse(Console.ReadLine(), out int vX);
                    
                    Console.Write("** 2 - Informe o valor de Y: ");
                    isNumeric = int.TryParse(Console.ReadLine(), out int vY);
                    
                    Console.Write("** 3 - Informe o valor de Z: ");
                    isNumeric = int.TryParse(Console.ReadLine(), out int vZ);

                    if (isNumeric)
                    {
                        x = vX;
                        y = vY;
                        z = vZ;

                        if (x > 0 && y > 0 && z > 0)
                        {
                            lineXY = x + y;
                            lineXZ = x + z;
                            lineZY = z + y;

                            sumLineXYXZ = lineXZ + lineXY;
                            sumLineXYZY = lineXY + lineZY;
                            sumLineXZZY = lineXZ + lineZY;

                            if ((sumLineXYZY > lineXZ) || (sumLineXZZY > lineXY) || (sumLineXYXZ > lineZY))
                            {
                                triangle = true;
                            }
                            if (triangle == true)
                            {
                                if ((sumLineXYXZ + sumLineXYZY + sumLineXZZY) % 3 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nO TRIÂNGULO É EQUILÁTERO!!\n");
                                    Console.ResetColor();
                                }
                                else if ((lineXY == lineXZ) || (lineXZ == lineZY) || (lineXY == lineZY))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nO TRIÂNGULO É ISÓSCELES!!\n");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nO TRIÂNGULO É ESCALENO!!\n");
                                    Console.ResetColor();
                                }
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n====================================================================");
                            Console.WriteLine("TRIÂNGULO INVÁLIDO!! OS VALORES INFORMADOS DEVEM SER POSITIVOS!!");
                            Console.ResetColor();
                            continue;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n====================================================================");
                        Console.WriteLine("SÓ PODEM SER INFORMADOS VALORES NUMÉRICOS!!");
                        Console.ResetColor();
                        continue;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("OPÇÃO INVÁLIDA!!");
                    Console.ResetColor();
                    continue;
                }
            } while (option != "s" || option == "S");
        }
    }
}

