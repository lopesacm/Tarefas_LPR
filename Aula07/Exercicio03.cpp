#include <iostream>
using namespace std;

int main(){
    int desejo =1;
    int matriz[4][4]=
    {{0,524,521,882},
     {524,0,434,586},
     {521,434,0,429},
     {882,586,429,0}
    };
    while(desejo==1)
    {

        cout<<"Vitoria->0"<<endl;
        cout<<"BH->1"<<endl;
        cout<<"RJ->2"<<endl;
        cout<<"SP->3"<<endl;
        int posicao[2]={0,0};
        for(int i=0; i<2;i++){
            cout<<"Digite a cidade que deseja ir"<<endl;
            cin>>posicao[i];
        }
        cout<<"A distancia é "<<matriz[posicao[1]][posicao[2]]<<""<<endl;
        cout<<"Deseja viajar para outro lugar? 1-sim 2-não"<<endl;
        cin>>desejo;
    }


}
