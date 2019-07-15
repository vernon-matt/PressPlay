import Home from "./component/home";
import Artists from "./component/Artists";
import Albums from "./component/Albums";
import Songs from "./component/Songs";
import ApiAction from "./api/api-actions";


pageBuild();

function pageBuild(){
    home();
    artists();
    albums();
    songs();

}

function home(){
    const app = document.getElementById('app');
    const home = document.getElementById('nav__Home');
    home.addEventListener('click', function(){
        app.innerHTML = Home();
    })
};

function artists(){
    const app = document.getElementById('app');
    const artists = document.getElementById('nav__Artists');
    artists.addEventListener('click', function(){
        ApiAction.getRequest("https://localhost:44378/api/artists", artistlist => {
            app.innerHTML = Artists(artistlist);
        })
    })

    document.querySelector('#app').addEventListener("click", function(){
        if(event.target.classList.contains('add-artist_submit')){
            const artist = event.target.parentElement.querySelector('.add-artist_artisttext').value;
            ApiAction.postRequest("https://localhost:44378/api/artists", artist, artistlist => {
                document.querySelector('#app').innerHTML = Artists(artistlist)
            })
        }
    })
};
function albums(){
    const app = document.getElementById('app');
    const albums = document.getElementById('nav__Albums');
    albums.addEventListener('click', function(){
        app.innerHTML = Albums();
})
};
function songs(){
    const app = document.getElementById('app');
    const songs = document.getElementById('nav__Songs');
    songs.addEventListener('click', function(){
        app.innerHTML = Songs();
    })
};

