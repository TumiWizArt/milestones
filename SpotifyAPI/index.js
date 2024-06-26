
//Importing the required modules
const readline = require('readline');//to read the input from the console
const { getSongDetails } = require('./spotify'); //importing a custom function from the spotify file


// This piece of code creates an interface for specifying the input and output stream
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});


//the next piece of code creates and shows a menu
const showMenu = () => {
  console.clear(); // Clear console before showing the menu
  console.log('-------------------------------------------')
  console.log('Menu:');
  console.log('-------------------------------------------')
  console.log('1. Search for a song on Spotify');
  console.log('2. Exit');
  console.log('-------------------------------------------')
  rl.question('Enter the number of your choice: ', handleMenuSelection);
};


//the following piece of code is used to handle the users input following the display of the menu
const handleMenuSelection = async (option) => {
  switch (option) {
    case '1':
      console.clear(); // Clear console before asking for the song name
      rl.question('What song are you looking for? ', async (songName) => {
        try {
          const songDetails = await getSongDetails(songName);
          console.clear(); // Clear console before showing song details
          console.log('Song Details:');
          console.log(`Artist(s): ${songDetails.artists}`);
          console.log(`Song: ${songDetails.name}`);
          console.log(`Preview: ${songDetails.preview_url}`);
          console.log(`Album: ${songDetails.album}`);
        } catch (error) {
          console.error('Error:', error.message);
        } finally {
          setTimeout(showMenu, 5000); // Delay showing the menu to allow reading the details
          console.log(' ')
          console.log('-------------------------------------------')
          console.log('The menu will display again in 5 seconds')
          console.log('-------------------------------------------')
        }
      });
      break;
    case '2':
      //exits the application
      console.clear();
      console.log('Thank you for using our app, Goodbye :)');
      setTimeout(() => {
        console.clear();
        rl.close();
      }, 2000);
      break;
    default:
      //if the user gives an invalid input, this code will run
      setTimeout(showMenu, 3000); 
      console.clear();
      console.log('Invalid option, please enter 1 or 2 when the menu displays');
      break;
  }
};

//invokes the menu
showMenu();
