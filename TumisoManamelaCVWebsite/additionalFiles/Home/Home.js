// var container = document.getElementsByClassName("container");
// var canvas = document.querySelector("canvas");

// canvas.height = innerHeight;
// canvas.width = innerWidth;

// var c = canvas.getContext("2d");

// c.beginPath();
// c.arc(600, 180, 100, 0, Math.PI *2, false);
// c.fillStyle = blue;
// c.fill();
// c.stroke();

//document.addEventListener("DOMContentLoaded", function(){

    var homeLink = document.getElementsByClassName("homeL");
    var portLink = document.getElementsByClassName("portfolioL");
    var aboutLink = document.getElementsByClassName("aboutL");
    var conLink = document.getElementsByClassName("contactL");
    
    var c2 = document.getElementById("c2");
    

    function settingElements(element){
        for(var i=0; i<element.length; i++){

            if(element[i] == undefined){
                continue;
            }
            else{
                return element[i];
            }
            
        }
    }


   

   //settingh the elements
    var changePort = settingElements(portLink);
    var changeHome = settingElements(homeLink);
    var changeContact = settingElements(conLink);
    var changeAbout = settingElements(aboutLink);


    //seting the colors
    //hover
    function hovering(element){
        element.addEventListener('mouseover', function(){

            element.style.color = "#78bbeb";
            changeHome.style.color = "black";
     });
 
 
     element.addEventListener('mouseout', function(){
 
         element.style.color = "black";
         changeHome.style.color = "#78bbeb";
     });
    }

    hovering(changePort);
    hovering(changeAbout);
    hovering(changeContact);
    

    var dx = 0.5;
    var r = 28; 

    //   animate();
// var changePort;
    
    
    // for(var i =0; i<portLink.length; i++){
    //     portLink[i].addEventListener("mouseover", function(){
    
    //     // portLink[i].style.color = "#78bbeb";
    //     console.log(portLink[i]);
    // });






