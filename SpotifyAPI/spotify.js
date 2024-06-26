//Importing required modules
const Spotify = require("spotify-web-api-node");
//dotenv is a module that helps keep sensitive information out of the main code
//in this case the Client ID, and Client Secret is the sensitive information
require("dotenv").config();


//creating an instance of the required module
//it also tells the program where to find the id and secret
const spotifyApi = new Spotify({
  clientId: process.env.SPOTIFY_CLIENT_ID,
  clientSecret: process.env.SPOTIFY_CLIENT_SECRET,
});

const getSongDetails = async (songName) => {
  try {
    const data = await spotifyApi.clientCredentialsGrant();
    spotifyApi.setAccessToken(data.body["access_token"]);

    const response = await spotifyApi.searchTracks(`track:${songName}`);
    const track = response.body.tracks.items[0];
    if (!track) {
      throw new Error("No track found");
    }
    return {
      artists: track.artists.map((artist) => artist.name).join(", "),
      name: track.name,
      preview_url: track.preview_url,
      album: track.album.name,
    };
  } catch (error) {
    console.error("Error fetching song details:", error.message);
    throw error;
  }
};

//this piece exports the function getSongDetails in order to use it in another file
module.exports = { getSongDetails };