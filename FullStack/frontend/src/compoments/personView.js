const PersonView = ({person, setMessage})=>{

    const deletePerson = async ()=>{
        try{
            const deletedPerson = await fetch('/api/'+person._id, {
                method: 'DELETE'
            })

            if(deletedPerson.ok){
                await window.location.reload();

                // await setMessage(person.name+'has been deleted')

                // await setTimeout(()=>{
                //     setMessage('')
                // }, 2000)

                
            }
        }
        catch(err){
            console.log(err.message)
        }
    }

    return (
        <div className="personView">
            <p>{person.name}</p>
            <p><b>age:</b> {person.age}</p>
            <span className="deleteBTN" onClick={deletePerson}>delete</span>
            <hr/>
        </div> 
    )
}

export default PersonView