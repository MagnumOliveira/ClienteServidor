package android.projeto;


import android.app.Activity;  
import android.os.Bundle;  
import android.util.Log;  

public class MainActivity extends Activity {  
  private WebService ws = new WebService();  
    
  @Override  
  public void onCreate(Bundle savedInstanceState) {  
      super.onCreate(savedInstanceState);  
      setContentView(R.layout.main);  
      operacao("somar", 2, 2, "Somar");  
      operacao("subtrair", 6, 3, "Subtrair");  
      operacao("multiplicar", 7, 3, "Multiplicar");  
      operacao("dividir", 21, 3, "Dividir");  
  }  
    
  public void operacao(String operacao, Integer numA, Integer numB, String texto) {  
      operacao = ws.webServiceOperacao(operacao, numA, numB);  
      // Filtra o valor retornado pelo WebService  
      String[] primeiraParte = operacao.split("=");  
      String[] segundaParte = primeiraParte[1].split(";");  
      String retorno = segundaParte[0];  
      Log.i("webservice", texto + ": " + Integer.valueOf(retorno));  
  }  
}  