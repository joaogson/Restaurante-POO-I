using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurante;

class Program
{

    static void Main(string[] args)
    {
        bool menu = true;
        Gerenciador gerenciador = new Gerenciador();


        while (menu)
        {

            Console.Clear();
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Gerenciar Restaurantes");
            Console.WriteLine("2. Gerenciar Pratos ");
            Console.WriteLine("3. Pedidos");
            Console.WriteLine("5. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {

                case "1":
                    //Lógica de Gerenciamento de Restaurantes
                    Console.Clear();
                    Console.WriteLine("----Restaurantes----");
                    Console.WriteLine("1. Adicionar Restaurante");
                    Console.WriteLine("2. Listar Restaurantes");

                    string opcaoRestaurante = Console.ReadLine();

                    switch (opcaoRestaurante)
                    {
                        case "1":

                            gerenciador.CadastrarRestaurante();
                            break;

                        case "2":

                            gerenciador.ListarRestaurantes();
                            break;
                    }

                    break;
                case "2":
                    //Lógica de Gerenciamento de Pratos
                    Console.Clear();
                    Console.WriteLine("----Pratos----");
                    Console.WriteLine("1. Adicionar Prato");
                    Console.WriteLine("2. Remover Prato");
                    Console.WriteLine("3. Listar Pratos");

                    string opcaoPrato = Console.ReadLine();

                    switch (opcaoPrato)
                    {

                        case "1":
                            gerenciador.AdicionaPrato();
                            break;

                        case "2":
                            gerenciador.RemovePrato();
                            break;

                        case "3":
                            gerenciador.ListarPratos();
                            break;
                    }

                    break;
                case "3":

                    Console.Clear();
                    Console.WriteLine("1. Presencial");
                    Console.WriteLine("2. Delivery");

                    string opcaoTipoPedido = Console.ReadLine();

                    switch (opcaoTipoPedido)
                    {
                        case "1":


                            Console.Clear();
                            Console.WriteLine("1. Fazer um pedido");
                            Console.WriteLine("2. Adicionar ao pedido");
                            Console.WriteLine("3. Listar pedido");

                            string opcaoPresencial = Console.ReadLine();
                            PedidoPresencial pedidoPresencial = new PedidoPresencial();
                            switch (opcaoPresencial)
                            {
                                case "1":
                                   
                                    pedidoPresencial.FazerPedido();

                                    break;
                                case "2":

                                    break;
                                case "3":

                                    break;
                                case "4":

                                    break;
                            }
                            break;
                        case "2":

                            Console.Clear();
                            Console.WriteLine("1. Fazer um pedido");
                            Console.WriteLine("2. Adicionar ao pedido");
                            Console.WriteLine("3. Listar pedido");

                            string opcaoDelivery = Console.ReadLine();
                            PedidoDelivery pedidoDelivery = new PedidoDelivery();

                            switch (opcaoDelivery)
                            {
                                case "1":
                                    pedidoDelivery.FazerPedido();

                                    break;
                                case "2":


                                    break;
                                case "3":
                                    Console.WriteLine("Informe o numero do pedido");
                                    string numPedido = Console.ReadLine();
                                    pedidoDelivery.DetalhesPedido(numPedido);
                                    break;
                                case "4":

                                    break;
                            }

                            break;
                    }




                    break;
                case "4":

                    break;
                case "5":
                    menu = false;
                    break;
            }

        }

    }



}
