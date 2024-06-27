import{useEffect, useState} from 'react'

const Home = ()=>{
    const [data, setData] = useState(null)

    useEffect(()=>{
        const fetchData = async()=>{
            const response = await fetch('/s')
            const json = await response.json()

            if(response.ok){
                setData(json)
            }
            
        }


        fetchData()
    },[])

    return(
        <div className="home">
            <div className="containerHome">
                <h2>People</h2>
                <div className="peopleData">
                    {data && data.map((singleData)=>(
                        <div className="item">
                            <p key={singleData._id}>name: {singleData.name}</p>
                            <p key={singleData._id}>age: {singleData.age}</p>
                            <hr></hr>
                        </div>
                        
                    ))}
                </div>
                
            </div>
            
        </div>
    )
}

export default Home