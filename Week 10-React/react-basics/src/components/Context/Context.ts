import { createContext } from "react";
import { User } from "../Models/User";

export const UserContext = createContext<User | undefined>(undefined);

// Context acts as a wrapper around components
// any components within the wrapper have access to the context
// and can reference anything that is saved to it