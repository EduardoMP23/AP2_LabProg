//variaveis para armazena dados temporarios
string? esc = "";
string? esc2 = "";
string? nome = "";
string? NickName = "";
int contadorj = 0;
int contadore = 0;
string? temp = "";
string? fimloop = "1";

//Criação das equipes e jogadores 
Equipe eqA = new Equipe();Jogador j1 = new Jogador(),j2 = new Jogador(),j3 = new Jogador(),j4 = new Jogador(),j5 = new Jogador();
Equipe eqB = new Equipe();Jogador j6 = new Jogador(),j7 = new Jogador(),j8 = new Jogador(),j9 = new Jogador(),j10 = new Jogador();
Campeonato peqA = new Campeonato(), peqB = new Campeonato();

//inicio do loop e do programa
do{
Console.Clear();
Console.WriteLine("---------------------------------");
Console.WriteLine("Bem vindo ao Campeonato de CS GO");
Console.WriteLine("---------------------------------\n");
Console.WriteLine("\nO que gostaria de fazer ?\n");
Console.WriteLine("1 - Cadastrar Jogador(es)");
Console.WriteLine("2 - Montar equipe(s)");
Console.WriteLine("3 - Simular partida e Ver Resultados");
Console.WriteLine("0 - Sair");
esc = Console.ReadLine();

//Defini os Nomes e Nick's do jogadores
if (esc == "1")
{
do{
contadorj += 1;
Console.Clear();
Console.WriteLine("Nome do jogaodor:");
nome = Console.ReadLine();
if(j1.Nome == null)
{j1.Nome = nome;}
else if(j2.Nome == null)
{j2.Nome = nome;}
else if(j3.Nome == null)
{j3.Nome = nome;}
else if(j4.Nome == null)
{j4.Nome = nome;}
else if(j5.Nome == null)
{j5.Nome = nome;}
else if(j6.Nome == null)
{j6.Nome = nome;}
else if(j7.Nome == null)
{j7.Nome = nome;}
else if(j8.Nome == null)
{j8.Nome = nome;}
else if(j9.Nome == null)
{j9.Nome = nome;}
else if(j10.Nome == null)
{j10.Nome = nome;}

Console.WriteLine("Nick do jogador:");
NickName=Console.ReadLine();
if (j1.NickName == null)
{j1.NickName = NickName;}
else if(j2.NickName == null)
{j2.NickName = NickName;}
else if(j3.NickName == null)
{j3.NickName = NickName;}
else if(j4.NickName == null)
{j4.NickName = NickName;}
else if(j5.NickName == null)
{j5.NickName = NickName;}
else if(j6.NickName == null)
{j6.NickName = NickName;}
else if(j7.NickName == null)
{j7.NickName = NickName;}
else if(j8.NickName == null)
{j8.NickName = NickName;}
else if(j9.NickName == null)
{j9.NickName = NickName;}
else if(j10.NickName == null)
{j10.NickName = NickName;}
if(contadorj >= 10)
{break;}
}
while(true);{
Console.Clear();
Console.WriteLine("Máximo de jogadores cadastrados!!!");
Console.WriteLine("Tecle ENTER para continuar");
Console.ReadLine();
}}

//Defini os Nomes das equipes e seus jogadores 
else if(esc == "2"){
Console.WriteLine("Nome da 1ª equipe");
eqA.NomeEquipe = Console.ReadLine();
Console.WriteLine("Nome da 2ª equipe");
eqB.NomeEquipe = Console.ReadLine();
do{
Console.Clear();
Console.WriteLine("--------------------------------");
Console.WriteLine("Lista do jogadores cadastrados:");
Console.WriteLine("--------------------------------\n");
Console.WriteLine($"1-{j1.NickName}   2-{j2.NickName}\n3-{j3.NickName}   4-{j4.NickName}\n5-{j5.NickName}   6-{j6.NickName}\n7-{j7.NickName}   8-{j8.NickName}\n9-{j9.NickName}   10-{j10.NickName}");
Console.WriteLine($"\nQuais jogadores gostaria que estivesem na equipe {eqA.NomeEquipe}");
esc2 = Console.ReadLine();
if(esc2 == "1"){temp += j1.NickName;}
else if(esc2 == "2"){temp += j2.NickName;}
else if(esc2 == "3"){temp += j3.NickName;}
else if(esc2 == "4"){temp += j4.NickName;}
else if(esc2 == "5"){temp += j5.NickName;}
else if(esc2 == "6"){temp += j6.NickName;}
else if(esc2 == "7"){temp += j7.NickName;}
else if(esc2 == "8"){temp += j8.NickName;}
else if(esc2 == "9"){temp += j9.NickName;}
else if(esc2 == "10"){temp += j10.NickName;}
contadore += 1;
}
while(contadore != 5);
{
string? fomrA = eqA.AdiconarJogador(temp);
Console.WriteLine($"A equipe {eqA.NomeEquipe} está composta por: {fomrA}");
string? fomrB = eqA.AdiconarJogador(temp);
Console.WriteLine($"A equipe {eqB.NomeEquipe} está composta por: {fomrB}");
Console.ReadLine();}}

//simula a partida e já mostra o resultado
else if(esc == "3"){
j1.Jogar();j2.Jogar();j3.Jogar();j4.Jogar();j5.Jogar();j6.Jogar();j7.Jogar();j8.Jogar();j9.Jogar();j10.Jogar();
int PontosEquiA = peqA.IniciarPartida(j1.Pontos,j2.Pontos,j3.Pontos,j4.Pontos,j5.Pontos);
int PontosEquiB = peqB.IniciarPartida(j6.Pontos,j7.Pontos,j8.Pontos,j9.Pontos,j10.Pontos);
Console.WriteLine("Partida Finalizada !!!");
Console.ReadLine();
Console.Clear();
peqA.Classificações(PontosEquiA,PontosEquiB);
Console.ReadLine();}}

//Finaliza o loop e o programa
while(fimloop != "0");{
Console.Clear();
Console.WriteLine("Até logo !!");
}

//Classes --------
class Jogador{
public string? Nome;
public string? NickName;
public int Pontos;
public void Jogar(){
    Random rnd = new Random();
    Pontos += rnd.Next(1,101);
}}

class Equipe{
public string? NomeEquipe;
public string? Jogadores;
public void PontosTotais(){
}
public string AdiconarJogador(string a)
{
    return $"{a}";
}  }

class Campeonato{
public string? NomeCampeonato;
public string? EquipesParticipantes;
public int IniciarPartida(int a, int b, int c, int d, int e){
return a+b+c+d+e;
}

public void Classificações(int a, int b){


if(a > b){
    Console.WriteLine($"1º Lugar:{a}\n2º Lugar:{b}");
}
else if(b > a){
    Console.WriteLine($"1º Lugar:{b}\n2º Lugar:{a}");
}}}