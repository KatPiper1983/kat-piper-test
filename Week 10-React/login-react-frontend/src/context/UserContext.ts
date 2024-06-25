import { createContext } from "react";
import { User } from "../Componenents/LogInComponent/LogInComponent";

export const UserContext = createContext<User | undefined>(undefined);