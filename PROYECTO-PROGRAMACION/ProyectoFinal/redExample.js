$('document').ready(function(){

        deb.nodes.add({id: "Pillofon", label: "Pillofon"});//1
        deb.nodes.add({id: "Trojes", label: "Trojes"});//2
        deb.nodes.add({id: "4 Esquinas", label: "4 Esquinas"});//3
        deb.nodes.add({id: "La Rosa", label: "La Rosa"});//4
        deb.nodes.add({id: "Sirpita", label: "Sirpita"});//5
        deb.nodes.add({id: "Lanza", label: "Lanza"});//6
        deb.nodes.add({id: "Terminal", label: "Terminal"});//7
        deb.nodes.add({id: "Villa Bush", label: "Villa Bush"});//8
        deb.nodes.add({id: "San simon", label: "San simon"});//9
        deb.nodes.add({id :"Correo" , label : "Correo"})//10


        deb.edges.add({from: "Pillofon", to: "Trojes", label: '5'});//
        deb.edges.add({from: "Pillofon", to: "Correo", label: '2'});
        deb.edges.add({from: "Pillofon", to: "Sirpita", label: '3'});
        deb.edges.add({from: "Correo", to: "Lanza", label: '1'});
        deb.edges.add({from: "Trojes", to: "4 Esquinas", label: '2'});//trojes a esquinas
        deb.edges.add({from: "Sirpita", to: "Lanza", label: '3'});//sirpita a lanza
        deb.edges.add({from: "Lanza", to: "Terminal", label: '3'});//lanza a terminal
        deb.edges.add({from: "4 Esquinas", to: "Sirpita", label: '3'});//4esquinas a sirpita 3
        deb.edges.add({from: "4 Esquinas", to: "La Rosa", label: '3'});//4esquinas a la rosa
        deb.edges.add({from: "4 Esquinas", to: "Villa Bush", label: '5'});//4esquinas a la rvilla bush
        deb.edges.add({from: "Sirpita", to: "Terminal", label: '2'});//sirpita a terminal 2
        deb.edges.add({from: "Terminal", to: "San simon", label: '5'});//terminal a san simon
         deb.edges.add({from: "San simon", to: "Villa Bush", label: '1'});//terminal a san simon
          deb.edges.add({from: "La Rosa", to: "Villa Bush", label: '2'});
});