const express = require('express')
const mongoose = require('mongoose')
const routes = require('./routes')

const app = express()

//middleware
app.use(express.json())
app.use('/api', routes)

mongoose.connect('mongodb+srv://tumi:1234@cluster0.uiu23bn.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0')
.then(()=>{
    app.listen(4000,()=>{
        console.log('listening')
    })
})
.catch(err => console.log(err))