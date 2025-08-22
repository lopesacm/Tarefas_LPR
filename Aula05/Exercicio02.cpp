#include <iostream>
#include <iomanip>
#include <random>
using namespace std;

int main()
{
    int chute,quantvezes=0;
    random_device numAleatorio ;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
    cout<<valorInteiro<<endl;
    do
    {
        cout<<"Adivinhe o numero"<<endl;
        cin>>chute;
        quantvezes++;
        if(chute>valorInteiro)
        {
            cout<<"chute alto"<<endl;
        }
        else if(chute<valorInteiro)
        {
            cout<<"chute baixo"<<endl;
        }
        
    }
    while(chute!=valorInteiro);{
        cout<<"acertou em "<<quantvezes<<" tentativa"<<endl;
    }
    
    
}