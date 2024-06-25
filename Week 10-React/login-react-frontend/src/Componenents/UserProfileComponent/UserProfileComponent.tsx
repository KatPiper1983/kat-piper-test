import React, { useContext } from 'react'
import { UserContext } from '../../context/UserContext'

function UserProfileComponent() {
    const user = useContext(UserContext);
  return (
    <div>
        {user?.firstName}
    </div>
  )
}

export default UserProfileComponent