package android.projeto;

import org.ksoap2.SoapEnvelope;  
import org.ksoap2.serialization.SoapObject;  
import org.ksoap2.serialization.SoapSerializationEnvelope;  
import org.ksoap2.transport.HttpTransportSE;  
  
public class WebService {  
    private static final String NAMESPACE = "com.service.Calculator";  
    private static final String URL = "localhost:8080";  
    private static final String SOAP_ACTION = "Calculator";  
      
    public String webServiceOperacao(String operacao, Integer numA, Integer numB) {  
        SoapObject request = new SoapObject(NAMESPACE, operacao);  
        SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);  
        String retorno = null;  
        // Adiciona parâmetros  
        request.addProperty("numA", numA);  
        request.addProperty("numB", numB);  
        envelope.setOutputSoapObject(request);  
        HttpTransportSE androidHttpTransport = new HttpTransportSE(URL);  
        try {  
            androidHttpTransport.call(SOAP_ACTION, envelope);  
            SoapObject resultsRequestSOAP = (SoapObject) envelope.bodyIn;  
            retorno = resultsRequestSOAP.toString();  
        } catch (Exception e) {  
            e.printStackTrace();  
        }  
        return retorno;  
    }  
}  

