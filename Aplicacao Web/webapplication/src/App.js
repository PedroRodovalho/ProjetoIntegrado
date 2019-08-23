import React from 'react';
//import logo from './logo.svg';
import './App.css';
//import './node_modules/elemental/less/elemental.less';
//import { Button, Form, FormInput,field,Checkbox } from 'elemental' 

function App() {
  return (
    <form align="Center">
      <field label="Email address" htmlFor="basic-form-input-email">
        <input autoFocus type="email" placeholder="Enter email" name="basic-form-input-email" />
      </field>
      <br></br>
      <field label="Password" htmlFor="basic-form-input-password">
        <input type="password" placeholder="Password" name="basic-form-input-password" />
      </field>
      <field>
        <checkbox label="Check it" />
      </field>
      <br></br>
      <button submit>Submit</button>
    </form>
  );
}

export default App;
