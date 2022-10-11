import { useState } from "react";
function App() {
  const [name, setName] = useState("");
  const [pnumber,setPnumber]=useState();
  const [error, setError] = useState("");
  const [contacts,setContact]=useState([
    { id: 1, cname: "Bharathi" ,phnumber:9042113862},
    { id: 2, cname:"Harini" ,phnumber:9362756993},
  ]);
  //delete contatct
  const deleteContact = (id) => {
    let newContacts = contacts.filter((contacts) => contacts.id !== id);
    setContact(newContacts);
    setError("");
    // setTodos(todos.filter((todo) => todo.id !== id));
  };
 
 //add Contact
  const add=()=>{
    if (name.length <= 0||pnumber.length<=0) {
      setError("Name or Phone number cannot be empty");
    } else 
setContact([...contacts,{id:contacts.length+1,cname:name,phnumber:pnumber}]);
setName("");
  };
  return (
   <>
    <div>
      <h1>Contact Book</h1>
      <p>
        Enter Name:
        <input
        type="text"
        value={name}
        onChange={(e)=>{
setName(e.target.value);
        }
        }
        />
         <span>{error}</span>
      </p>
      <p>
        Enter Phone Number:
        <input
        type="number"
        value={pnumber}
        onChange={(e)=>{
setPnumber(e.target.value);
        }
        }
        />
      </p> 
      <button onClick={()=>add()}>Add Contact</button>  
    </div>
    
     {contacts.length > 0 ? (
       <div>
         <h3>Contact List</h3>
         <div>
           {contacts.map((contacts) => {
             return (
               <p key={contacts.id}>
                <table border={1}>
                  <thead>                    
                      <td>Contact Name</td>
                      <td>Phone number</td>                    
                    </thead>
                    <tbody>
                    <td>{contacts.cname}</td>
                 <td>{contacts.phnumber}</td>
                    </tbody>
                </table>
                 
                 <button onClick={() => deleteContact(contacts.id)}>Remove</button>
               </p>
             );
           })}
         </div>
       </div>
     ) : (
       <p>No Contatcts to show!!!</p>
     )}
 </>
    
  );
};

export default App;
