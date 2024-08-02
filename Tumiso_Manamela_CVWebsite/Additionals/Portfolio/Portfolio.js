
var homeLink = document.getElementsByClassName("homeL");
var portLink = document.getElementsByClassName("portfolioL");
var aboutLink = document.getElementsByClassName("aboutL");
var conLink = document.getElementsByClassName("contactL");


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
        changePort.style.color = "black";
        
 });


 element.addEventListener('mouseout', function(){

     element.style.color = "black";
     changePort.style.color = "#78bbeb";
 });
}

hovering(changeHome);
hovering(changeAbout);
hovering(changeContact);

