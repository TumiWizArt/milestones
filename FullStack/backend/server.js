const express = require('express')
const routes = require('./Routes/routes')
require('dotenv').config()
const app = express()
const mongoose = require('mongoose')

//middleware
app.use(express.json())
app.use('/s', routes);



mongoose.connect('mongodb+srv://tumi:1234@cluster0.uiu23bn.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0')
.then(()=>{
    app.listen(4000, ()=>{
        console.log('listening...')
    }) 
})
.catch((err)=>{console.log(err)})



