#include <iostream>
#include <map>
using namespace std;

int main()
{
    map<string, int> city;
    cout<<"digite a quantidade de cidades:";
    int numerodecidades;
    cin>>numerodecidades;
    for(int i=0;i<numerodecidades;i++)
    {
        int populacao;
        string nome;
        cout<<"Digite o nome da cidade:";
        cin>>nome;
        cout<<"Digite a populacao da cidade:";
        cin>>populacao;
        city.insert({nome,populacao});
    }
    int soma = 0;
    int idmenor = 1000000;
    int idmaior = 0;
    string nomenor = "";
    string nomaior = "";
    for (auto popu: city)
    {
        soma += popu.second;
        if (popu.second < idmenor)
            {
            idmenor = popu.second;
            nomenor = popu.first;
        }
        if (popu.second > idmaior)
        {
            idmaior = popu.second;
            nomaior = popu.first;
        }
    }
    cout<<"Maior populacao:"<<nomaior<<endl;
    cout<<"Menor populacao:"<<nomenor<<endl;
    float media = soma / numerodecidades;
    for(auto maior : city)
    {
        if (maior.second > media)
        {
            cout<<"Acima da media:"<<maior.first<<endl;
        }
    }
    cout<<"Digite qual o valor de populacao quer remover?";
    int remover;
    cin>>remover;
    for (auto rem :city)
    {
        if (rem.second == remover) city.erase(rem.first);
    }
    for (auto d : city)
    {
        cout<<"Nome:"<<d.first<<", Populacao:"<<d.second<<endl;
    }
}