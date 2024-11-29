using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuentaBancariaConsole.Entidades;
    //ABSTRACCION : Que es y que hace un objeto
public class BanckAccount
{
    public string? id{get;private set;}
    public string? Nombres{get;set;}
    public string? Apellidos{get;set;}
    public decimal Saldo{get;private set;}

    //Constructor
    public BanckAccount(string id,string nombres, string apellidos, decimal saldo_inicial){
        //Validamos el numeroUnico
        if(id.Length<9 || id==null){
            throw new ArgumentOutOfRangeException("El numero unico de su cuenta es menor de 9 digitos");
        }
        this.id=id;
        this.Nombres=nombres;
        this.Apellidos=apellidos;
        this.ValidarSaldo(saldo_inicial);
    }

    //MEtodos
    //->Metodo para establecer El numero unico 
    public string setID(string id){
        if(id.Length<9){
            return "El numero unico de su cuenta es menor de 9 digitos";
        }
        this.id=id;
        return "EXITO. Su nuevo numero de cuenta bancaria es " + this.id;
    }

    public void Deposito(){
        //
    }

    //Acepta reintegros, no aceptan numeros negativos
    public void Reintegros(){}

    //Verificacion del salo inicial positivo
    private void ValidarSaldo(decimal saldo){
        if(saldo<0){
            throw new ArgumentOutOfRangeException("El saldo no puede ser un numero negativo");
        }
        this.Saldo=saldo;
    }

}