// Call the dataTables jQuery plugin
$(document).ready(function() {
listar_usuarios();
alert("pruebatabla");
  $('#dataTable').DataTable();
});
async function listar_usuarios(){
     const respuesta=await fetch("pruebatabla",{
           method:'GET',
           headers: {'Accept':'application/json'}
     });
     const contenido=await respuesta.json();
     console.log(contenido);
     let filas="";
     for(let u of contenido){
         filas+="</td><td>"+u.id+"</td><td>"+u.nombre+"</td><td>"+u.apellido+"</td><td>"+u.email+"</td><td>"+u.telefono+"</-td><td>-</td></tr>"
     }
     document.querySelector('#dataTable tbody').outerHTML=filas;
}
