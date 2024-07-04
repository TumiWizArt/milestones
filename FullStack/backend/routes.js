const express = require('express')
const router = express.Router()
const Person = require('./person')

//find all
router.get('/', async(req, res)=>{
    const people = await Person.find()
    res.status(200).json(people)
})

//find one
router.get('/:id', async(req,res)=>{
    const {id} = req.params
    const foundOne = await Person.findById({_id: id})
    res.status(200).json(foundOne)
})


//create
router.post('/', async(req, res)=>{
    const{name, age} = req.body
    try{
        const created = await Person.create({name: name, age: age})
        res.status(200).json(created)
    }
    catch(err){
        res.status(404).json({error: err})
    } 
})

//delete
router.delete('/:id', async(req,res)=>{
    const {id} = req.params

    const deletedPerson = await Person.findOneAndDelete({_id: id})
    res.status(200).json(deletedPerson)
})

//update
router.patch('/:id', async(req,res)=>{
    const {id} = req.params

    const updatedPerson = await Person.findOneAndUpdate({_id: id},
        {
            ...req.body
        }
    )

    res.status(200).json(updatedPerson)
})

module.exports = router