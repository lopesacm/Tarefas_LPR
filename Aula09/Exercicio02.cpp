#include <iostream>
#include <algorithm>
#include <list>

#include <ctime>
using namespace std;

int main()
{
    
    list<int> numeros;
    srand(time(0));
    for(int i =0 ; i<100;i++){
        numeros.push_back(rand() % 100 + 1);
    }
    numeros.sort();

    for(auto it = numeros.begin(); it != numeros.end();) {
        if (*it % 2 == 0) {
            it = numeros.erase(it);
        } else {
            ++it;
        }
    }

    for(auto it:numeros){
        cout << it << " ";
    }
    int maior = 0;
    for(auto x : numeros){
        cout << x << " ";
        if(x > maior){
            maior = x;
        } 
    }
    cout <<""<<endl;
    cout <<"Repete"<< endl;

    for(int i = 0; i <= maior; i++){
        int cont = 0;
        for(auto it = numeros.begin(); it != numeros.end();){
            if(*it == i){
               cont++;
               if(cont == 2){
                    cout << *it << " ";
               } 
            } 
            ++it;
        }
    }


}