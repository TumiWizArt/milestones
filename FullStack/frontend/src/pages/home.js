import {useState, useEffect} from 'react'
import PersonView from '../compoments/personView'

const Home = ()=>{
    const [people, setPeople] = useState(null)
    const [message, setMessage] = useState('')

    useEffect(()=>{
        const peopleFetched = async ()=>{
            const fetchedPeople = await fetch('/api')
            const json = await fetchedPeople.json()

            setPeople(json)
            
        }

        peopleFetched()
    },[])


    return(
        <div className="home">
            <h2>All people</h2>
            <div className="HomeMessage">{message}</div>
            <div className="peopleListContainer">
                <div className="personList">
                    {people && people.map((person)=>(
                        <PersonView key={person._id} person={person} setMessage={setMessage}/>
                    ))}
                </div>
            </div>
            
        </div>
    )
}

export default Home