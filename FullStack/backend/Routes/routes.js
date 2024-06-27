const express = require('express')
const router = express.Router()
const Person  = require('../models/person')

router.get('/',async (req,res)=>{
    try{
        const people = await Person.find()
        res.json(people)
        console.log('people retrieved')
    }
    catch(err){
        res.json({err: err.message})
    }
    
})

router.post('/', async(req,res)=>{
    const { name, age} = req.body

    if(!name || !age){
        return(
            res.json({err: "some ish wrong"})
        )
    }

    try{
        const createdPerson = await Person.create({name, age})
        res.status(200).json(createdPerson)
        console.log('person created')
    }
    catch(error){
        res.json({err: error.message})
    }

        

})

module.exports = router