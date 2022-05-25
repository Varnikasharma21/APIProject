const url='http://localhost:54735/api/BOOKS';
document.getElementById('btn1').addEventListener('click',getData);

function getData(){
    var requestOptions = {
     method: 'GET',
        redirect: 'follow'
      };
   fetch(url, requestOptions)
.then(response => response.text())
 .then(result => show1(result))
.catch(error => console.log('error', error));}     
function show1(data) {
document.getElementById('fm1').innerHTML = data;
}

//data by id
document.getElementById('btn2').addEventListener('click', getS);
function getS(){
  var id=document.getElementById("box").value;
  var url='http://localhost:54735/api/BOOKS/'+id;
  fetch(url)
  .then(response => response.text())
  .then(result=> show2(result))
  .catch(error => console.log('Errorrr', error));}
  function show2(data){
document.getElementById('fm1').innerHTML = data;
  }

  //insert
  function sendJSON(){
    let bookName = document.getElementById("box2");
    let bookAuthor = document.getElementById("box3");
    let bookSeller = document.getElementById("box4");
    let bookCode = document.getElementById("box5");
    let totalPages = document.getElementById("box6");
    let bookPrice = document.getElementById("box7");
    // Creating a XHR object
    let xhr = new XMLHttpRequest();
    let url = "http://localhost:54735/api/BOOKS";
  
    xhr.open("POST", url, true);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.onreadystatechange = function () {
     if (xhr.readyState === 4 && xhr.status === 200) {
            result.innerHTML = this.responseText;
        }
    };


    // Converting JSON data to string
   var data = JSON.stringify({  "bookName": bookName.value , "bookAuthor":bookAuthor.value,"bookSeller":bookSeller.value, "bookCode":bookCode.value,"totalPages":totalPages.value ,"bookPrice":bookPrice.value});

    xhr.send(data);
}



function get4() {
  var id=document.getElementById("like").value;
  var url="http://localhost:54735/api/BOOKS/"+id;
  fetch(url)
  .then((res) => res.text())

  .then(ans => showData(ans))  
  }
function showData(data)
{
 document.getElementById('fm1').innerHTML=data;
}

