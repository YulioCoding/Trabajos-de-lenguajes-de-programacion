#include <iostream>
#include <fstream>
#include <string>
using namespace std;

struct Producto{
    int id;
    string nombre;
    float precio;
    int cantidad;
};

const int MAX = 100;
Producto inventario [MAX];
int total = 0;

void cargarArchivo(){
    ifstream f("inventario.txt");
    total = 0; 
    while (f>>inventario[total].id>>inventario[total].nombre>>inventario[total].precio>>inventario[total].cantidad){
    total++;
    }
}

void guardarArchivo(){
    ofstream f("inventario.txt");
    for(int i=0;i<total;i++)
    f<<inventario[i].id << ""<< inventario[i].nombre <<""<<inventario[i].precio <<""<< inventario[i].cantidad<< "\n";
}

void agregarProducto(){
    Producto p;
    cout << "\nID: "; cin >> p.id;
    cout << "Nombre: "; cin >> p.nombre;
    cout << "Precio: "; cin >> p.precio;
    cout << "Cantidad: "; cin >> p.cantidad;
    
    for (int i = 0; i<total; i++){
        if (inventario[i].id == p.id){
            cout << "Ya existe el ID. \n";
            return;
        }
    }
    
    inventario[total] = p;
    total++;
    guardarArchivo();
    cout<<"Producto agregado. \n";
}

void listarProductos() {
    cout << "\nID\tNombre\t\tPrecio\tCantidad\n";
    for (int i=0; i<total; i++){
        cout << inventario[i].id << "\t" << inventario[i].nombre << "\t\t"<< inventario[i].precio << "\t" << inventario[i].cantidad << "\n";
    }
}    

void buscarProducto(){
    int id;
    cout << "\nID a buscar: "; 
    cin >> id;
    
    for (int i = 0; i<total; i++){
        if(inventario[i].id == id){
            cout << "ID: " << inventario[i].id << "Nombre: " << inventario[i].nombre << "Precio: "<< inventario[i].precio << "Cantidad: " << inventario[i].cantidad<<"\n";
            return;
        }
    }
    cout << "Producto no encontrado \n";
}

void actualizarCantidad(){
    int id, nuevaCantidad;
    cout << "\nID: ";   
    cin >> id;
    cout << "Nueva cantidad: "; 
    cin >> nuevaCantidad;
    for (int i=0; i<total; i++){
        if (inventario[i].id == id){
            inventario[i].cantidad = nuevaCantidad;
            guardarArchivo();
            cout << "Cantidad actualizada \n";
            return;
        }
    }
    cout << "Producto no encontrado \n";
}

void calcularValorTotal(){
    float valorTotal = 0;
    for (int i = 0; i<total; i++)
        valorTotal += inventario[i].precio * inventario[i].cantidad;
        cout << "\nValor total del inventario: $"<< valorTotal << "\n";
}

int main(){
    cargarArchivo();
    
    int opcion;
    do{
    cout<<"\n1. Agregar producto\n2. Listar productos\n3. Buscar por ID\n4. Actualizar cantidad\n5. Valor total\n6. Salir\nOpcion: ";
    cin >> opcion;
    switch(opcion){
        case 1:agregarProducto(); break;
        case 2:listarProductos(); break; 
        case 3:buscarProducto(); break;
        case 4:actualizarCantidad(); break;
        case 5:calcularValorTotal(); break;
    }
  }while (opcion!=6);

    return 0;
}
