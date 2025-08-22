#include "iostream"
#include "string.h"
using namespace std;

void inverter(char num[])
{
    int len = strlen(num) - 1;
    string num_revert = "";
    for (int i = 0; i <= len; i++)
    {
        num_revert += num[len-i];
    }
    cout<<num_revert;
}



int main(){
    char numero[]= "";
    cout<<"Digite o numero"<<endl;
    cin>>numero;
    inverter(numero);

}
