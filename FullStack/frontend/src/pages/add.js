import {useState} from 'react'

const Add = ()=>{

    const [name, setName] = useState('')
    const [age, setAge] = useState('')
    const [msg, setMsg] = useState('')
    
    const addPerson = async (e)=>{
        e.preventDefault()

        const person = {name, age}

        

        try{
            const addedPerson = await fetch('/api', {
                method: 'POST',
                body: JSON.stringify(person),
                headers: {'Content-Type':'application/json'}
            })

            if(addedPerson.ok){
                setMsg('Person added :)')
            }

            if (!addedPerson.ok) {
                throw new Error('An error occurred while adding the person.');
              }
        }
        catch(err){
            console.log(err.message)
        }
    }

    const clearin = (n) =>{
        n('')
    }


    return(
        <div className="add">
            <h2>Add person</h2>
            <div className="form">
                <form >
                    <input 
                    onClick={()=> clearin(setName)}
                    value={name}
                    onChange={(e)=> setName(e.target.value)}
                    type="text" 
                    className="nameI" 
                    placeholder="name"
                    />

                    <input 
                    onClick={()=> clearin(setName)}
                    value={age}
                    onChange={(e)=> setAge(e.target.value)}
                    type="text" 
                    className="nameI" 
                    placeholder="age"
                    />

                    <button onClick={addPerson}>
                        Add
                    </button>
                </form>
            </div>

            <p className="msg">{msg}</p>
            

        </div>
    )
}

export default Add