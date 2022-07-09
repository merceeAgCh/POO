package Java.Repaso;

import javax.swing.*;

public class Duenio extends Automovil{
    double precio;
    String nombreD;
    //constructor
    public Duenio(String colors, String marcas, String modelos, double precios, String nombreDs) {
        super(colors, marcas, modelos);
        this.nombreD = nombreDs;
        this.precio = precios;
    }
    @Override
    public void verDatos(){
        JOptionPane.showMessageDialog(null, "Marca: " +marca + "\nModelo: " + modelo + "\nPrecio: " + precio + "\nDuenio: " + nombreD, "Datos del duenio del auto", JOptionPane.INFORMATION_MESSAGE );
    }
}
