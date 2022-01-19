import React, { useState } from "react";
import Form from "react-bootstrap/Form";
import axios from "axios";
import Button from "react-bootstrap/Button";
import { Link } from "react-router-dom";

const AddInventoryView = () => {
    const [inventoryName, setInventoryName] = useState("");
    const [inventoryDescription, setInventoryDescription] = useState("");
    const [inventoryAmount, setInventoryAmount] = useState(0);
    
};
export default AddInventoryView;