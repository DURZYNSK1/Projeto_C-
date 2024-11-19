using System;
using PROJETO_02.Models;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);


Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");