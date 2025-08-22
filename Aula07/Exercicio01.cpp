
#include <iostream>
#include <vector>
using namespace std;

int main(){
    vector<int>numeros(10);
    int numeros_par = 0;
    int numeros_impar = 0;
    for(int i =0;i<numeros.size();i++)
    {
        int valor=0;
        cout<<"Digite o "<<(i+1)<<" numero"<<endl;
        cin>>valor;
        if(valor%2 == 0)
        {
            numeros_par++;
        }else{
            numeros_impar++;
        }
        numeros[i] = valor;
    }
    vector<int>par(numeros_par);
    vector<int>impar(numeros_impar);
    int aaaaa=0;
    int bbbbb=0;
    for(int i = 0; i<numeros.size(); i++)
    {
        if(numeros[i]%2 == 0)
        {
            par[aaaaa]=numeros[i];
            aaaaa++;
        }
        else
        {
            impar[bbbbb] =numeros[i];
            bbbbb++;
        }
    }
    cout<<"PARES: ";
    for(int j=0;j<par.size();j++){
        cout<<par[j]<<" ";
    }
    cout<<endl;
    cout<<"IMPAR: ";
    for(int j=0;j<impar.size();j++){
        cout<<impar[j]<<" ";
    }
}